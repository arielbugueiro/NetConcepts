namespace Delegates
{
    public class Delegate
    {
        /*
         Delegates : Are functions that delegate taks to other functions
        Is a reference to a method
         */


        //Definition of the Delegated Object
        delegate void ObjectDelegate(string mesagge);
        delegate void MyDelegate();
        static void Main(string[] args)
        {
            //Creation of object delegate pointing to WelcomeMessage
            string hi = "Fine";
            ObjectDelegate myDelegate = new ObjectDelegate(WelcomeMessage.GreetingWelcome);

            myDelegate(hi);

            //Creation of object delegate pointing to GoodByMessage
            MyDelegate Mdelegate = new MyDelegate(GoodByeMessage.GreetingGoodBye);
            Mdelegate();


        }
    }

    public class WelcomeMessage
    {
        public static void GreetingWelcome(string msj)
        {
            Console.WriteLine("Hi, How are you?: {0}", msj);
        }
    }

    public class GoodByeMessage
    {
        public static void GreetingGoodBye()
        {
            Console.WriteLine("See you later");
        }
    }

}