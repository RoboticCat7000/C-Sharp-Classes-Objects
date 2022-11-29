namespace MyApp
{
    class Cat : Animal
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public override void makeSound()
        {
            Console.WriteLine("Meow meow!");
        }
    }
}