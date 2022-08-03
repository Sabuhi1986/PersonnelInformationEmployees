using PersonnelInformationEmployees.DataOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PersonnelInformationEmployees.MenecmentSystem;
using System.Data;

namespace PersonnelInformationEmployees.DataOperation
{
    public class EmployeeMenecmentSystem
    {
        public static string datasource = "Data Source=DESKTOP-LM539FN\\SQLEXPRESS;Initial Catalog=EmpMenSyst;Integrated Security=True";
        static DataOperation DataOperation = new DataOperation();

        public static void AddEmployee()
        {
          Employee employee = new Employee();
          Console.WriteLine("Iscinin nomresini daxil et:  ");
          employee.EmployeeID = int.Parse(Console.ReadLine());
          Console.WriteLine("Iscinin Adini daxil et:  ");
          employee.Name = Console.ReadLine();
          Console.WriteLine("Iscinin Soyadini daxil et:  ");
          employee.Surname = Console.ReadLine();
          Console.WriteLine("Iscinin giris tarixini daxil et: GG/AA/IL ");
          employee.DateEmployment =DateTime.Parse(Console.ReadLine());
          Console.WriteLine("Iscinin unvanini daxil et:  ");
          employee.Adress = Console.ReadLine();
          Console.WriteLine("Iscinin emek haqqi emsalini daxil et:  ");
          employee.WageRate =decimal.Parse(Console.ReadLine());
          Console.WriteLine("Iscinin bir ayda calisdigi umumi deqiqeni daxil et:  ");
          employee.TotalMinutesWork = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(datasource);
            connection.Open();
            string insertQuery = "INSERT INTO [dbo].[tblPersonel] ([EmployeeID],[Name], [Surname],  [DateOfEmployment], [WageRate], " +
                "[TotalMinutesWork]) VALUES (@EmployeeID, @Name, @Surname, @DateOfEmployment,  @WageRate, @TotalMinutesWork)";

            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@Name", employee.Name);
            insertCommand.Parameters.AddWithValue("@Surname", employee.Surname);
            insertCommand.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            insertCommand.Parameters.AddWithValue("@DateOfEmployment", employee.DateEmployment);
            insertCommand.Parameters.AddWithValue("@WageRate", employee.WageRate);
            insertCommand.Parameters.AddWithValue("@TotalMinutesWork", employee.TotalMinutesWork);
            
            insertCommand.ExecuteNonQuery();
            connection.Close();



            DataOperation.Employees.Add(employee);
            }
            public static void ShowEmployee() 
            {
            foreach (var item in DataOperation.Employees)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine($"Iscinin nomresi : {item.EmployeeID}");
                Console.WriteLine($"Iscinin adi: {item.Name}");
                Console.WriteLine($"Iscinin Soyadi : { item.Surname}");
                Console.WriteLine($"Iscinin giris tarixi :{item.DateEmployment}");
                Console.WriteLine($"Iscinin unvani: {item.Adress}");
                Console.WriteLine($"Iscinin emek haqqisi: {item.WageRate * item.TotalMinutesWork} AZN");
                Console.WriteLine($"Iscinin emek haqqi emsali: {item.WageRate}");
                Console.WriteLine($"Iscinin bir ayda islediyi deqiqe: {item.TotalMinutesWork}");
                Console.WriteLine("*************************************");
            }
                 
        }
    }
 

}
