using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            

            Console.WriteLine("print your name");
            string name1 = Console.ReadLine();
            Console.WriteLine("print your age");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("print your gender");
            string gender1 = Console.ReadLine();
            Console.WriteLine("print your adress");
            string adress1 = Console.ReadLine();

            Console.WriteLine("Name: " + name1);
            Console.WriteLine("Age: " + age1);
            Console.WriteLine("Gender: " + gender1);
            Console.WriteLine("Adress: " + adress1);
            Console.ReadLine();











            Console.Write("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;
            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

            result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

            result = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

            result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);













            string fname;
            string lname;
          
            Console.WriteLine("your first name");
            fname = Console.ReadLine();

            Console.WriteLine("your last name");
            lname = Console.ReadLine();
            Console.WriteLine(fname+" "+lname);
        }
    }
}
