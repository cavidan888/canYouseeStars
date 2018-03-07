using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forExample
{
    class Program
    {
        static void Main(string[] args)
        {
            solarSystem ss = new solarSystem();
            ss.ask = Console.ReadLine();

            ss.isnight(); 
        }
    }

    class solarSystem
    {
        public string ask;
        public bool isNight;
        

        public bool isnight()
        {
            isNight = false;

            if (ask == "Night")
            {

                isNight = true;

                if (isNight == true)
                {
                    Console.WriteLine("Gecedir Ulduzlar Gorunur");
                }
            }
            else
            {
                isNight = false;

                if (isNight == false)
                {
                    Console.WriteLine("Gunduzdur Ulduzlar Gorunmur");
                }
            }

            return isNight;
            
        }
    }
}
