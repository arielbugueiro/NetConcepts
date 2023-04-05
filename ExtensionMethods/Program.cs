namespace ExtensionMethods
{
    class Program
    {
        /*
         Extension Method: Allows extending the funcionality of an object with type o static method
         */
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("hello world!".FirstCapitalLetter());


            //Exercise 2
            var shoppingCart = new ShoppingCart();
            shoppingCart.Products.Add(new Product
            {
                Name = "Product1",
                Price = 20
            });
            shoppingCart.Products.Add(new Product
            {
                Name = "Product2",
                Price = 40
            });
            shoppingCart.Products.Add(new Product
            {
                Name = "Product3",
                Price = 10
            });

            Console.WriteLine($"Total Price = { shoppingCart.GetPriceTotal()}");
        }
    }

    //First Example
    public static class ExampleExtensionMethod
    {
        public static string FirstCapitalLetter(this string phrase)
        {
            char fistLetter = char.ToUpper(phrase[0]);
            string restPhrase = phrase.Substring(1);

            return fistLetter + restPhrase;
        }
    }

    //Second Example
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }


    public class ShoppingCart
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }

    public static class ShopingCartExtension
    {
        public static double GetPriceTotal(this ShoppingCart shoppingCart)
        {
            double priceTotal = 0;
            foreach (var product in shoppingCart.Products)
            {
                priceTotal += product.Price;
            }

            return priceTotal;
        }
    }
}