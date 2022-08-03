using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInformationEmployees.DataOperation
{
    public class WorkTimeMenecmentSystem
    {
        public static void AddWorkTime()

        {

            ShowWorkTime worktime = new ShowWorkTime();
            Console.WriteLine("Isci nomresini elave edin:");
            worktime.PersonalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Tarix elave edin:");
            worktime.Date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Giris saati daxil edin;");
            worktime.EntryTime = int.Parse(Console.ReadLine());
            Console.WriteLine("Giris deqiqesini daxil edin:");
            worktime.ExitMinute = int.Parse(Console.ReadLine());
            Console.WriteLine("Cixis saatini daxil edin");
            worktime.ExitHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Cixis dediqesini daxil edin");
            worktime.ExitMinute = int.Parse(Console.ReadLine());

            DataOperation.WorkTimes.Add(worktime);
        }
        public static void ShowWorkTime()
        {
            foreach (var item in DataOperation.WorkTimes)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine($"Iscinin nomresi {item.PersonalNumber}");
                Console.WriteLine($"Tarix {item.Date}" );
                Console.WriteLine($"Giris saati {item.EntryTime}");
                Console.WriteLine($"Giris deqiqesi {item.EntryMinute}");
                Console.WriteLine($"Cixis saati {item.ExitHour}");
                Console.WriteLine($"Cixis deqiqesi {item.EntryMinute}");
                Console.WriteLine("**************************************");
                
            }
          
        
        }


    }


}
