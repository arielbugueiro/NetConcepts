public class LambdaExpressions
{

    /*
    Lambda Expressions: Funciones anonimas. Sirven para ejecutar funciones que no necesitan ser nombradas. para simplificar el codigo.
     Se usan en Linq y al crear delegados.
    */


    public delegate int DelegateSuma(int x, int y);

    public delegate bool DelegateCompara(int Age1, int Age2);
    static void Main(string[] args)
    {

        DelegateSuma myDelegate = new DelegateSuma((x,y) => x+y);
        Console.WriteLine(myDelegate(2,4));
        Console.WriteLine("*******************************");

        //Exercise 2
       List<int> listNumbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};
        List<int> numberPeers = listNumbers.FindAll(i => i % 2 == 0);
        numberPeers.ForEach(x => {
            Console.WriteLine("Numero Par:");
            Console.WriteLine(x);
            });
        //foreach (int i in numberPeers) Console.WriteLine(i);

        //Exercise 3
       Persona p1 = new Persona();
        p1.Name= "Pedro";
        p1.Age = 20;

        Persona p2 = new Persona();
        p2.Name = "Ana";
        p2.Age = 20;

        DelegateCompara newDelegate = (persona1, persona2) => persona1 == persona2;
        Console.WriteLine(newDelegate(p1.Age, p2.Age));
    }



    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}