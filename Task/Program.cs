public class Program
{
    static async Task Main(string[] args)
    {
        await MakeBreakfastAsync();
    }


    static async Task MakeBreakfastAsync()
    {
        Console.WriteLine("Adding 1 to 2 teaspoons of coffee to mug ...");
        var boilingWater =  BoilWaterAsync();
        var hotMilk = HeatMilkAsync();
        Console.WriteLine("Add sugar ...");
        Console.WriteLine("Set table ...");

        await Task.WhenAll(boilingWater,hotMilk);
        Pour(boilingWater.Result);
        Pour(hotMilk.Result);



        Console.WriteLine("Drink");
    }
    static async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("Boiling water started...");

        Console.WriteLine("Waiting for water to be hot...");
        await Task.Delay(5000);
        Console.WriteLine("Boiling water complete...");

        return "hot water";
    }

    static async Task<string> HeatMilkAsync()
    {
        Console.WriteLine("Heating milk started...");

        Console.WriteLine("Waiting for milk to be hot...");
        await Task.Delay(3000);
        Console.WriteLine("Heating milk complete...");

        return "hot milk";
    }

    static void Pour(string drink)
    {
        Console.WriteLine($"Pouring {drink} in mug ...");
    }
}