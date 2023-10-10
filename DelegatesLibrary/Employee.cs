using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate void LeaveRequestHandler(int requestedDays);
    public class Employee
    {

        public event LeaveRequestHandler LeaveRequested;

        private int _Leaves;

        public int Leaves
        {
            get { return _Leaves; }
            set { _Leaves = value; }
        }

        public Employee()
        {
            this.Leaves = 10;


        }

        public void ApplayForLeave(int Leaves)
        {
            if (this.Leaves >= Leaves)
            {
                this.Leaves -= Leaves;


                Console.WriteLine($"remaining leaves {this.Leaves}  : {this.Leaves}");
            }
            else
            {
                Console.WriteLine(" Leaves limit has Crossed ");

            }
        }


        }
}
