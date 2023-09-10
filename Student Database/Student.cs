using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SMS_JUN_JULY
{
    class Student
    {
        public String sname;
        public String batchname;
        public String dob;
        public String gender;
         

        //constructor=>get executed whenever object created
        public Student(String a, String b, String c, String d)
        {
            this.sname = a;
            this.batchname = b;
            this.dob = c;
            this.gender = d;
            
        }


        //This is where we display student details
        public void display_details()
        {
            
            Console.WriteLine("Student Details");
            Console.WriteLine("=====================");
            Console.WriteLine("Student Name = " + this.sname);
            Console.WriteLine("Batch = " + this.batchname);
            Console.WriteLine("Date of Birth = " + this.dob);
            Console.WriteLine("Gender = " + this.gender);
        }
    }
}