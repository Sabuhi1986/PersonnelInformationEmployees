using PersonnelInformationEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInformationEmployees.DataOperation
{
    public class DataOperation
    {
        public static List<Employee> Employees { get; set; }
        public static List<ShowWorkTime> WorkTimes { get; set; }
        

        static DataOperation()
        {
            Employees = new List<Employee>();
            WorkTimes = new List<ShowWorkTime>();
                        

        }
     }

} 



    
     
  
