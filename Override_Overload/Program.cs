public class Program
{
    static async Task Main(string[] args)
    {
        //Overloading - Applicable within the same class
        MathBasics operations = new MathBasics();
        int result = operations.Add(2, 3);
        int result1 = operations.Add(2, 3, 4);
        Console.WriteLine(result);
        Console.WriteLine(result1);


        //Overriding: provides a new version of a method inherited from a parent class. inherited method must be: Abstract, Virtual or Already Overriden
        //Used with ToString(), polymorphism

        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Speak();
        cat.Speak();

    }


    class MathBasics
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *guau guau*");
        }
    }

    class Cat : Animal
    {
       

    }
}