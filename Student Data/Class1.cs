using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************
    Juan Rodriguez
    CIST 2341
    C# Programming 1
    Lab #10
This is my code....
*****************************************************************/
namespace Student_Data
{
    class Class1
    {
        public String name { get; set; }="";
        public String address { get; set; }="";
        public String phone { get; set; }="";
        public String email { get; set; }= "";
        public String major { get; set; }="";
        public double gpa { get; set;  }=0;

        public void Display() {
             Console.WriteLine(name+" "+address+" "+phone+" "+email+" "+major+" "+gpa);
        }

    }
}
