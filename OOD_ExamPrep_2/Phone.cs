using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_ExamPrep_2
{
    public class Phone
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone()
        {

        }

        public Phone (string name, decimal price, string operatingSystem, string os_image ="", string phone_image = "")
        {

        }

        public void IncreasePrice(double increase)
        {
            Price *= (decimal)(increase + 1);
        }
    }
}
