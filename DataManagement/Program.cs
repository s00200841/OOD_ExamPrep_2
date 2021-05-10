using OOD_ExamPrep_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Database is created so no need to reuse this code( ex. start it)
namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneData db = new PhoneData();

            using (db)
            {
                // Create Objects (Phones)
                Phone phone1 = new Phone("Samsung", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone phone2 = new Phone("iPhone 12", 600, "IOS", "/images/apple.png", "/images/iphone11.png");

                Console.WriteLine("Creating Phones");

                // Add Phones to Database
                db.Phones.Add(phone1);
                db.Phones.Add(phone2);

                Console.WriteLine("Adding Phones To Database");

                // Save the Datebase
                db.SaveChanges();

                Console.WriteLine("Saved To Database");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
            }
        }
    }
}
