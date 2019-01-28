/* Author: Gregory Gauthier
 * Date: 1/25/2019
 * Comments: This C# Program Will Execute an Array Loop
 **/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today, we wil be creating a manually populated array!!");
            Console.WriteLine("First, I will be Manually Populating the Array with a Set of Strings");

            //Manually Populated Array Below

            //Here, I am displaying in order the list of the last 25 presidents of the United States, each is separated by a new line 
            string[] Presidents = {" Obama", "\n Bush", "\n Clinton", "\n Bush Sr.", "\n Reagan", "\n Carter", "\n Ford", "\n Nixon", "\n Kennedy", "\n Eisenhower",
                "\n Truman", "\n Roosevelt", "\n Hoover", "\n Coolidge", "\n Harding", "\n Taft", "\n Roosevelt", "\n Mckinley", "\n Cleveland", "\n Harrison", "\n Arthur",
                "\n Garfield", "\n Hayes", "\n Grant", "\n Johnson"};

            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Here Is a List of the Last 25 True Presidents of The United States:");
            Console.WriteLine("__________________________________________________________________________");

            //Here, I want to loop through each array until the list has been exhausted
            foreach (string i in Presidents)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n __________________________________________________________________________");

            Console.ReadKey(true);




        }
    }
}
