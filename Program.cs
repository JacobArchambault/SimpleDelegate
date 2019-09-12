using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{

    // This delegate can point to any method, taking two integers and returning an integer.
    public delegate int BinaryOp(int x, int y);

    // This class contains methods BinaryOp will point to.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            // Create an instance of the SimpleMath class, and a BinaryOp delegate object that 'points to' that instance.
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);

            // Show information about this object.
            DisplayDelegateInfo(b);

            // Invoke Add() method indirectly using delegate object.
            Console.WriteLine("10 + 10 is {0}", b(10, 10));

            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member in the delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}
