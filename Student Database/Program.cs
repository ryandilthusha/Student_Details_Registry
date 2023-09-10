using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SMS_JUN_JULY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Students are there ? ");
            int scount = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= scount)
            {
                Console.WriteLine(" Student " + i + " Information ");

                Console.WriteLine("Enter Name : ");
                String studentname = Console.ReadLine();

                Console.WriteLine("Enter Batch Name : ");
                String studentbatch = Console.ReadLine();

                Console.WriteLine("Enter Your DOB : ");
                String studentdb = Console.ReadLine();

                Console.WriteLine("Enter Your Gender : ");
                String studentgender = Console.ReadLine();


                //create student object=> classname objectname = new classname();
                Student std = new Student(studentname, studentbatch, studentdb, studentgender);

                //lets display both students details
                std.display_details();
                i++;
            }

            Console.ReadKey();
        }
    }
}

