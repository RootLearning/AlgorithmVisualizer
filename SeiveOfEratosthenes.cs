using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiveInteract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 200;
            interact(n);
            //Console.WriteLine(ans);
           // print_int_array(ans);

        }
        static public void interact(int n)
        {
            int[] ans=new int[n+1] ;
            for (int i = 0; i <=n; i++)
            {
                ans[i]=i;

            }
            print_int_array(ans);
             Console.WriteLine("Enter number 2");

             int a = Convert.ToInt16(Console.ReadLine());
             if (a == 2)
             {
                 for (int j = 0; j <ans.Length; j++)
                 {
                     if (ans[j] == 2)
                     {
                         ans[j] = 2;
                     }
                     
                     else if (ans[j] % 2 == 0||ans[j]==1)
                     {
                         ans[j] = 0;
                     }
                 }
                 print_int_array(ans);
             }
             Console.WriteLine("Enter number 3");
             int b = Convert.ToInt16(Console.ReadLine());
             if (b == 3)
             {
                 for (int j = 0; j < ans.Length; j++)
                 {
                     if (ans[j] == 3)
                     {
                         ans[j] = 3;
                     }
                     else  if (ans[j] % 3 == 0)
                     {
                         
                         
                             ans[j] = 0;
                         
                     }
                 }
                 print_int_array(ans);
             }
             Console.WriteLine("Enter number 5");
             int c = Convert.ToInt16(Console.ReadLine());
             if (c == 5)
             {
                 for (int j = 0; j < ans.Length; j++)
                 {
                     if (ans[j] == 5)
                     {
                         ans[j] = 5;
                     }
                     else if (ans[j] % 5 == 0)
                     {
                         ans[j] = 0;
                     }
                 }
                 print_int_array(ans);
             }
             Console.WriteLine("Enter number 7");
             int d = Convert.ToInt16(Console.ReadLine());
             if (d == 7)
             {
                 for (int j = 0; j < ans.Length; j++)
                 {
                     if (ans[j] == 7)
                     {
                         ans[j] = 7;
                     }
                      else if (ans[j] % 7 == 0)
                     {
                         ans[j] = 0;
                     }
                 }
                 print_int_array(ans);
             }

            
     
           
        }

        static public void print_int_array(int[] ma)
        {
            for (int i = 0; i < ma.Length; i++)
            {
                Console.Write(ma[i] + "\t");
            }
            Console.WriteLine();

        }
        static public int GetInterger(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            int tempvalue;
            if (!int.TryParse(Console.ReadLine(), out tempvalue))
            {
                return GetInterger("Please enter the valid integer :");
            }
            return tempvalue;
        }

 
    }
}



