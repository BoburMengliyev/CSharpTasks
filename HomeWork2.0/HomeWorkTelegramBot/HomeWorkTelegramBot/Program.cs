using System.Text.Json;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace HomeWorkTelegramBot
{
    class Program
    {
        static ITelegramBotClient bot;

        static Dictionary<long, (string Name, string Username)> users = new();
        static Dictionary<long, List<Homework>> homeworks = new();

        public class Homework
        {
            public string Subject { get; set; }
            public string Title { get; set; }
            public DateTime DueDate { get; set; }
        }
        static async Task Main()
        {
            string token = "8381407737:AAGJ-j-Y0sxvk-ow19CAX1fOUM5x8aqlRCA";
            bot = new TelegramBotClient(token);

            var me = await bot.GetMe();
            Console.WriteLine($"Bot ishga tushdi: @{me.Username}");

            bot.StartReceiving(HandleUpdateAsync, HandleErrorAsync);

            Console.ReadLine();
        }

        static async Task HandleUpdateAsync(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, System.Threading.CancellationToken cancellationToken)
        {
            if (update.Type != UpdateType.Message || update.Message!.Type != MessageType.Text)
                return;

            var message = update.Message;
            var text = message.Text!;
            long userId = message.From.Id;

            if (text.StartsWith("/start"))
            {
                users[userId] = (message.From.FirstName, message.From.Username ?? "NoUsername");
                homeworks[userId] = new List<Homework>();
                await bot.SendMessage(userId, "Salom! 👋 Uy vazifalarini boshqarish botiga xush kelibsiz.");
            }
            else if (text.StartsWith("/profile"))
            {
                if (!users.ContainsKey(userId))
                {
                    await bot.SendMessage(userId, "Iltimos, avval /start buyrug‘ini bering.");
                    return;
                }
                var (name, username) = users[userId];
                await bot.SendMessage(userId, $"👤 Ism: {name}\n📛 Username: @{username}\n📚 Uy vazifalari soni: {homeworks[userId].Count}");
            }
            else if (text.StartsWith("/addhw"))
            {
                await bot.SendMessage(userId, "Fan nomini kiriting:");
                stepState[userId] = "subject";
            }
            else if (text.StartsWith("/myhw"))
            {
                if (!homeworks.ContainsKey(userId) || homeworks[userId].Count == 0)
                {
                    await bot.SendMessage(userId, "Sizda uy vazifalari yo‘q.");
                    return;
                }

                string reply = "📚 Uy vazifalaringiz:\n";
                int i = 1;
                foreach (var hw in homeworks[userId])
                {
                    reply += $"{i}. {hw.Subject} - {hw.Title} - Due: {hw.DueDate:yyyy-MM-dd}\n";
                    i++;
                }
                await bot.SendMessage(userId, reply);
            }
            else if (text.StartsWith("/done"))
            {
                try
                {
                    int index = int.Parse(text.Split(' ')[1]) - 1;
                    if (index >= 0 && index < homeworks[userId].Count)
                    {
                        var removed = homeworks[userId][index];
                        homeworks[userId].RemoveAt(index);
                        await bot.SendMessage(userId, $"✅ '{removed.Title}' bajarildi va o‘chirildi.");
                    }
                    else
                    {
                        await bot.SendMessage(userId, "Noto‘g‘ri raqam.");
                    }
                }
                catch
                {
                    await bot.SendMessage(userId, "Foydalanish: /done <raqam>");
                }
            }
            else if (text.StartsWith("/schedule"))
            {
                string timetable = """
                    🗓 Haftalik jadval:
                    Dushanba - Matematika, Ingliz tili
                    Seshanba - Fizika, Tarix
                    Chorshanba - Kimyo, Adabiyot
                    Payshanba - Biologiya, Matematika
                    Juma - Informatika, Sport
                    """;
                await bot.SendMessage(userId, timetable);
            }
            else if (text.StartsWith("/help"))
            {
                string helpText = """
                    📌 Buyruqlar:
                    /start - Boshlash
                    /profile - Profil ma'lumotlari
                    /addhw - Uy vazifasi qo‘shish
                    /myhw - Uy vazifalarini ko‘rish
                    /done <raqam> - Vazifani bajarilgan deb belgilash
                    /schedule - Haftalik jadval
                    /help - Yordam
                    """;
                await bot.SendMessage(userId, helpText);
            }
            else
            {
                await HandleHomeworkSteps(userId, text);
            }
        }

        // Uy vazifasi qo'shish jarayonini boshqarish
        static Dictionary<long, string> stepState = new();
        static Dictionary<long, Homework> tempHomework = new();

        static async Task HandleHomeworkSteps(long userId, string text)
        {
            if (!stepState.ContainsKey(userId))
                return;

            string step = stepState[userId];

            if (step == "subject")
            {
                tempHomework[userId] = new Homework { Subject = text };
                stepState[userId] = "title";
                await bot.SendMessage(userId, "Vazifa sarlavhasini kiriting:");
            }
            else if (step == "title")
            {
                tempHomework[userId].Title = text;
                stepState[userId] = "date";
                await bot.SendMessage(userId, "Tugash sanasini kiriting (yyyy-MM-dd):");
            }
            else if (step == "date")
            {
                if (DateTime.TryParse(text, out DateTime dueDate))
                {
                    tempHomework[userId].DueDate = dueDate;
                    homeworks[userId].Add(tempHomework[userId]);
                    tempHomework.Remove(userId);
                    stepState.Remove(userId);
                    await bot.SendMessage(userId, "✅ Uy vazifasi qo‘shildi.");
                    SaveData(); // Ma'lumotlarni saqlash
                }
                else
                {
                    await bot.SendMessage(userId, "Sanani noto‘g‘ri kiritdingiz. Qayta kiriting:");
                }
            }
        }

        static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, System.Threading.CancellationToken cancellationToken)
        {
            Console.WriteLine(exception);
            return Task.CompletedTask;
        }

        // Ma'lumotlarni faylga saqlash
        static void SaveData()
        {
            var data = new
            {
                Users = users,
                Homeworks = homeworks
            };

            string filePath = @"E:\B_M__Personal Profile\C#\HomeWorkTelegramBot\BotData\homeworks.txt";

            // Papka yo'q bo'lsa, yaratamiz
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // Fayldan ma'lumotlarni yuklash
        static void LoadData()
        {
            if (File.Exists("homeworks.txt"))
            {
                string json = File.ReadAllText("homeworks.txt");
                var data = JsonSerializer.Deserialize<SaveModel>(json);
                if (data != null)
                {
                    users = data.Users;
                    homeworks = data.Homeworks;
                }
            }
        }

        // JSON deserializatsiya uchun model
        public class SaveModel
        {
            public Dictionary<long, (string Name, string Username)> Users { get; set; }
            public Dictionary<long, List<Homework>> Homeworks { get; set; }
        }
    }
}
