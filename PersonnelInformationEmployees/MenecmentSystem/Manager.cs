using PersonnelInformationEmployees.DataOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInformationEmployees.MenecmentSystem
{
    public class Manager<T>
    {
     

        public static void serviceCall()
        {

            Type employee = typeof(Employee);
            if (typeof(T) == employee)
            {
                EmployeeMenecmentSystem.AddEmployee();
                EmployeeMenecmentSystem.ShowEmployee();
            }
            Type worktime = typeof(ShowWorkTime);
            if (typeof(T) == worktime)
            {
                WorkTimeMenecmentSystem.AddWorkTime();
                WorkTimeMenecmentSystem.ShowWorkTime();
            }
            
        }
    }
}
