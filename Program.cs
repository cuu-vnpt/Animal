public class Program
{
    public static void Main(string[] args)
    {
        Cat mycat = new Cat("40","165");
    }
}
    public abstract class Animal
    {
        protected string weight{get;set;}
        
        protected string height{get;set;}

        public Animal(string weight, string height)
        {
            this.weight = weight;
            this.height = height;
        }
        public virtual void PrintInfo()
        {

        }

    }
    public class Cat : Animal 
    {
        public Cat(string weight, string height) : base(weight,height)
    {

    }
    }
