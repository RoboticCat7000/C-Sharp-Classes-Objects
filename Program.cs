namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat myAnimal = new Cat("Funten", 3);
            Console.WriteLine(myAnimal.Age);
            Console.WriteLine(myAnimal.Name);
            myAnimal.makeSound();


        }


    }
}