using DelegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class SecondMain : EventArgs
   
    {
        public static void Main(string[] args)
        {

            Employee e = new Employee();

            e.LeaveRequested += HandleLeaveRequest;

            Console.WriteLine($"Employee has {e.Leaves} leaves initially.");

            Console.Write("Enter the number of days for leave request: ");
            int requestedDays = int.Parse(Console.ReadLine());

            e.ApplayForLeave(requestedDays);

            Console.ReadLine();
        }

        static void HandleLeaveRequest(int requestedDays)
        {
            Console.WriteLine($"Leave request approved for {requestedDays} days.");
            Console.Read();
        }

      


    }
}
