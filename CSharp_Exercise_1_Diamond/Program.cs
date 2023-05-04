public class CSharp_Exercise_1_Diamond
{
  static void Main(string[] args)

  {
    int i, j;

    var tryAgain = true;
    while (tryAgain)
    {
      Console.WriteLine("Display the pattern like diamond:");
      Console.WriteLine("-----------------------------------\n");
      Console.Write("Input number of rows (half of the diamond:  ");
      int number_Rows = Convert.ToInt32(Console.ReadLine());
      int count = number_Rows - 1;

        for (j = 1; j <= number_Rows; j++)
        {
          for (i = 1; i <= count; i++)
          Console.Write(" ");
          count--;
          for (i = 1; i <= 2 * j - 1; i++)
          Console.Write("*");
          Console.WriteLine();
        }
        count = 1;
        for (j = 1; j <= number_Rows - 1; j++)
        {
          for (i = 1; i <= count; i++)
          Console.Write(" ");
          count++;
          for (i = 1; i <= 2 * (number_Rows - j) - 1; i++)
          Console.Write("*");
          Console.WriteLine();
        }
        Console.ReadLine();

        Console.WriteLine("Do you want to run the program again?");
        Console.Write("Press Y for Yes and then choose a number or N to close it. (Y/N): ");
        var runAgain = Console.ReadLine();
      
        if (runAgain == ("N") | runAgain == ("n"))
        {
          tryAgain = false;
        }              
    }
  }
}






