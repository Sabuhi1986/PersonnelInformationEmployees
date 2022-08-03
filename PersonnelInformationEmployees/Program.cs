using PersonnelInformationEmployees.DataOperation;
using PersonnelInformationEmployees.MenecmentSystem;
using System;

namespace PersonnelInformationEmployees
{
    class Program
    {
        

        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("*************İşçilərin kadr məlumatlarının və iş vaxtının izlənməsi proqramı*************");
            Console.WriteLine();
            Console.WriteLine("===============Sorğulanma proqramı===============");
            Console.WriteLine();
            Console.WriteLine("1) İşçinin məlumatlarının göstərilməsi:");
            Console.WriteLine("2) İşçinin məlumatlarının göstərilməsi və həmin ay üzrə iş məlumatların göstərilməsi:");
            Console.WriteLine("3) Müəyyən bir ünvana görə işçilərin siyahısının görüntülənməsi:");
            Console.WriteLine("4) İşə qəbul olunan işçilərin sayının illər üzrə bölgüsünün görüntülənməsi:");
            Console.WriteLine("5) İşə gec gələn işçilərin siyahısı:");
            Console.WriteLine("6) Müəyyən bir günün əlavə iş qeydlərinin sadalanması:");


            Console.WriteLine();
            Console.WriteLine("===============Yenilənmə proqramı===============");
            Console.WriteLine();
            Console.WriteLine("7)  Yeni işçinin əlavə edilməsi:");
            Console.WriteLine("8)  İşçi məlumatlarının yenilənməsi:");
            Console.WriteLine("9)  Müəyyən bir günün iş qeydlərinin əlavə edilməsi:");
            Console.WriteLine("10) İşçinin məlumatlarının dosyalardan silinməsi:");
            Console.WriteLine("11) İşçilər faylının ehtiyat nüsxəsinin çıxarılması:");
            Console.WriteLine("12) Çıxış");


            int secimetmek = int.Parse(Console.ReadLine());
            switch (secimetmek)
            {

                case 1:

                    Manager<Employee>.serviceCall();
                    
                    menu();
                    break;


                case 2:

                    Manager<ShowWorkTime>.serviceCall();
                    menu();
                    break;

                case 3:

                    menu();
                    string iscontinue = "he";
                    do
                    {
                        
                        Console.WriteLine("Davam etmək istəyirsiniz? ");
                        iscontinue = Console.ReadLine().ToLower();
                    }
                    while (iscontinue == "hə");
                    break;
                    
                default:
                    break;
            }
        }
    }
}