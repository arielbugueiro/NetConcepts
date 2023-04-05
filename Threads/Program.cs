public class Program
{
    /*
     Los hilos (thread) se ejecutan en paralelo.
     Se pueden sincronizar (con el método Join)
     */
    static void Main(string[] args)
    {

        Thread t = new Thread(MetodoSaludo);
        t.Start();
        //t.Join(); //Se utiliza para sincronizar. Una vez que termina el thread, comienza el otro.
        

        Console.WriteLine("Hola mundo desde hilo 1");
        Thread.Sleep(1000);           
        Console.WriteLine("Hola mundo desde hilo 1");
        Thread.Sleep(1000);          
        Console.WriteLine("Hola mundo desde hilo 1");
        Thread.Sleep(1000);          
        Console.WriteLine("Hola mundo desde hilo 1");
        Thread.Sleep(1000);          
        Console.WriteLine("Hola mundo desde hilo 1");
        Thread.Sleep(1000);

        //MetodoSaludo();
    
    }

    static void MetodoSaludo()
    {
        Console.WriteLine("Hola mundo desde hilo 2");
        Thread.Sleep(1000);
        Console.WriteLine("Hola mundo desde hilo 2");
        Thread.Sleep(1000);          
        Console.WriteLine("Hola mundo desde hilo 2");
        Thread.Sleep(1000);         
        Console.WriteLine("Hola mundo desde hilo 2");
        Thread.Sleep(1000);          
        Console.WriteLine("Hola mundo desde hilo 2");
        Thread.Sleep(1000);
    }
}