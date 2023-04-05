using ValueTypes;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Value Type = 
            
            El valor se copia en la nueva ubicación, por lo que hay dos copias idénticas del mismo valor en la memoria.
            Examples are int, char, double,struct, enum and float, which stores floating point numbers. 
            (variables are stored in the STACK)

            Reference Type = 
            
            La referencia se copia mientras que el valor real sigue siendo el mismo
            Example are Arrays, Class, Interfaces, Delegate. 
            (variables are stored in the HEAP)             
            
             */

            //Value Type
            //1 - Exercise
            int x = 100;
            int y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("********************");

            y = 200;

            Console.WriteLine("********************");
            Console.WriteLine(x);
            Console.WriteLine(y);


            //Reference Type
            //2 - Exercise
            int[] a = { -5 };
            int[] b = a;


            Console.WriteLine("********************");
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);

            b[0] = 10;

            Console.WriteLine("********************");
            Console.WriteLine(a[0]);
            Console.WriteLine(b[0]);


            //Value Type
            //3 - Exercise
            x = 100;

            ChangeNumber(x);

            Console.WriteLine("********************");
            Console.WriteLine(x);

            static void ChangeNumber(int x)
            {
                x = 7400;
            }

            //Reference Type
            //4- Exercise
            Console.WriteLine("********************");
            Person p1 = new Person();
            p1.Name = "Arnol";
            p1.Age = 45;

            ChangeObject(p1);

            Console.WriteLine();
            Console.WriteLine($"p1.Name = {p1.Name}\np1.Age = {p1.Age} ");

            static void ChangeObject(Person p1)
            {
                p1.Name = "Frank";
                p1.Age = 70;
            }

            //5 - Exercise
            Console.WriteLine("********************");
            Person person1 = new Person();
            Person person2 = person1;

            Console.WriteLine($"Persona1.Age = {person1.Age}\nPerson2.Age = {person2.Age}");             //person1.Age=25 and person2.Age=25
            Console.WriteLine();

            person2.Age = 12;
            Console.WriteLine($"Person1.Age = {person1.Age}\nPerson2.Age = {person2.Age}");           //person1.Age=12 and person2.Age=12
            Console.WriteLine();


            person1.Age = 4;
            Console.WriteLine($"Persona1.Age = {person1.Age}\nPerson2.Age = {person2.Age}");           //person1.Age=4 and person2.Age=4
            Console.WriteLine("********************");


            //6 - Exercise
            //Differences between Value and Reference Types.

            //Reference Type
            MyClass firstClass = new MyClass(7);
            MyClass secondClass = firstClass;
            secondClass.value = 5;
            Console.WriteLine("Class: " + firstClass.value + "\n" + secondClass.value);        //firstClass.value=5  secondClass.value=5

            //Value Type
            MyStruct firstStruct = new MyStruct(7);
            MyStruct secondStruct = firstStruct;
            secondStruct.value = 5;
            Console.WriteLine("Struct: " + firstStruct.value + "\n" + secondStruct.value); //firstClass.value=7  secondClass.value=5

        }

        public class MyClass
        {
            public int value;

            public MyClass(int value)
            {
                this.value = value;
            }
        }

        public struct MyStruct
        {
            public int value;

            public MyStruct(int value)
            {
                this.value = value;
            }
        }

    }
}
