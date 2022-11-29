namespace MyApp
{
    abstract class Animal
    {
        public string Name
        {
            set; get;
        }

        public int Age
        {
            get; set;
        }

        public abstract void makeSound();


    }
}