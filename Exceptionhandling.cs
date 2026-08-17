namespace CSharpLearning;
using System;
public class Exceptionhandling
{
 public void OrderOfExecution(string word)
    {
        try
        {
            int number1 = int.Parse(word);
            Console.WriteLine($"Converted number is : {number1}");
        }
        //catch (Exception)
        //{
        //    Console.WriteLine("Exception occured");
        //}
        catch(FormatException)
        {
            Console.WriteLine("Format exception");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Overflow exception");
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }

}