public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4 };
		int a = 5, b = 0, c = 0;
		try
		{
		//c = a / b;
        int x = numbers[4];
		
		}
		catch (IndexOutOfRangeException ex)
		{
            Console.WriteLine("Hubo un error con excepcion tipo IndexOutOfRangeException");
            Console.WriteLine(ex.Message);
		}
        catch (DivideByZeroException ex)
        {
			Console.WriteLine("Hubo un error con excepcion tipo DivideByZeroException");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo una excepcion global");
            Console.WriteLine(ex.Message);
        }
        finally
		{
			Console.WriteLine("Se ejecuta siempre el bloque finally");
		}
		Console.WriteLine("Fin");
    }

}