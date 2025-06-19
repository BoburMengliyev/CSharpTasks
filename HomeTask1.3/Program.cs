// #########################################
// ## Task 1
// ### Inheritance of Objects

//using HomeTask13.Person;

//Person[] people = new Person[3];

//Console.WriteLine("1 - talabaning ismini kiriting: ");
//string student1Name = Console.ReadLine();

//Console.WriteLine("2 - talabaning ismini kiriting: ");
//string student2Name = Console.ReadLine();

//Console.WriteLine("O‘qituvchining ismini kiriting: ");
//string teacherName =  Console.ReadLine();

//people[0] = new Teacher(teacherName);
//people[1] = new Student(student1Name);
//people[2] = new Student(student2Name);

//foreach (Person person in people) 
//{
//    Console.WriteLine(person.ToString());

//    if (person is Student student)
//    {
//        student.Study();
//    }
//    else if (person is Teacher teacher) 
//    {
//        teacher.Explain();
//    }
//}

// #########################################
// ## Task 2
// ### Photo Book Class

//using HomeTask13.PhotoBook;

//PhotoBook defaultAlbum = new PhotoBook();
//Console.WriteLine("Default album sahifalar soni: " + defaultAlbum.GetNumberPages());

//PhotoBook customAlbum = new PhotoBook(24);
//Console.WriteLine("24 sahifali albom sahifalar soni: " + customAlbum.GetNumberPages());

//BigPhotoBook bigPhotoBook = new BigPhotoBook();
//Console.WriteLine("BigPhotoBook sahifalar soni: " + bigPhotoBook.GetNumberPages());

// #########################################
// ## Task 3
// #### Abstract Classes

//using HomeTask13.Animal;

//Dog dog = new Dog();

//Console.WriteLine("Hayvon nomini kiriting: ");
//string inputName = Console.ReadLine();
//dog.SetName(inputName);
//Console.WriteLine(dog.GetName());
//dog.Eat();

// #########################################