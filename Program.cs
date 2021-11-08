
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    namespace abstractdemo_implementation
    {
        partial class Student//partial-interface
        {
            string name;
            string Email;
            long mobileno;
            int rollno;

            public void Display()
            {
                Console.WriteLine("Student Details");
            }

        }
        partial class Student :placement//inheritance
        {
            public void Message()
            {
                Console.WriteLine("implementation of partial class");
            }
        }
    abstract class placement
    {
        string nameofinstitute;
        int noofstudentsplaced;
        DateTime yearofplacement;

        public void placementrecord()
        {
            Console.WriteLine("method will show placement records");
        }
    }

   /* interface Exam
    {
        public void Mcqbased();
        public void Questionbased();

    }*/
}