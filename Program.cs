using System.IO;

namespace Zachary_Renyhart_Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: "); //This is asking the user for inputs
            string myName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your address");
            string myAddress = Console.ReadLine();
            


            {
                //This is creating a file in my file folder with whatever I create. (I notepad)
                StreamWriter writer = new StreamWriter("D:\\Sample1.txt"); //This is what the file location is
                writer.WriteLine();
                writer.WriteLine("Hello, " + myName + " in the CCAD14 class ");
                
                writer.WriteLine("You are " + myAge + " years old ");

                writer.WriteLine("And your address is " + myAddress);
                //Closing the file
                writer.Close();

                String line; //creating this string to read to object of "reader"


                StreamReader reader = new StreamReader("D:\\Sample1.txt"); //This now reads everything from the file I have created
                line = reader.ReadLine();
                while (line != null) //This will print out the lines until this is null or nothing is left in the string.
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                reader.Close();
                Console.ReadLine();
            }
        }
    }
}
