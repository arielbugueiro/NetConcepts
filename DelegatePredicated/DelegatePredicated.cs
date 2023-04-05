public class DelegatePredicated
{

    /*
    Predicated Delegate:  Boolean functions that Return True or False
    */

    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        numbers.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        Predicate<int> newDelegatePredicate = new Predicate<int>(GetPeers);
        List<int> peers = numbers.FindAll(newDelegatePredicate);

        //existNumbersPeers = numbers.Exists(newDelegatePredicate);

        foreach (int num in peers)
        {
            Console.WriteLine(num);
        }

    }
    static bool GetPeers(int num)
    {
        return num % 2 == 0;
    }
}