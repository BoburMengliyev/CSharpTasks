using ExamTask.Animal;

class Program
{
    static void Main()
    {
        Animal cat = new Cat("Kitty");
        cat.Greets();

        Dog dog1 = new Dog("Buddy");
        Dog dog2 = new Dog("Max");
        dog1.Greets();
        dog1.Greets(dog2);

        BigDog bigDog1 = new BigDog("Rex");
        BigDog bigDog2 = new BigDog("Bruno");
        bigDog1.Greets();
        bigDog1.Greets(dog1);
        bigDog1.Greets(bigDog2);
    }
}