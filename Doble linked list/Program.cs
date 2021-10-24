using System;
using System.IO;

namespace Doble_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] A = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 2\file1.txt");
                DLL List_A = new DLL();
                foreach (string line in A)
                {
                    List_A.addtotail(Convert.ToInt32(line));
                }
                List_A.PrintList();
                Console.WriteLine("\nThe middle node is " + List_A.returnNodevalue());
                List_A.BasicPrimnums();


                string[] B = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 2\file2.txt");
                DLL List_B = new DLL();
                foreach (string line in B)
                {
                    List_B.addtotail(Convert.ToInt32(line));
                }
                List_B.PrintList();
                Console.WriteLine("\nThe middle node is " + List_B.returnNodevalue());
                List_B.BasicPrimnums();

                string[] C = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 2\file3.txt");
                DLL List_C = new DLL();
                foreach (string line in C)
                {
                    List_C.addtotail(Convert.ToInt32(line));
                }
                List_C.PrintList();
                Console.WriteLine("\nThe middle node is " + List_C.returnNodevalue());
                List_C.BasicPrimnums();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numeric values");
            }
            catch (FileNotFoundException) //Currently Throwing error in visual studios before reaching this
            {
                Console.WriteLine("Please check file paths of files");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please make sure the files are within 32 bit limits");
            }
            catch
            {
                Console.WriteLine("An unideified error has occured");
            }
        }
    }
}
