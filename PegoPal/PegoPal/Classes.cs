using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegoPal
{
    class Classes
    {
        public static int IsAuth = 0;
        public static int Level = 1;

        //Stat Calc
        public static int Hits { get; set; }
        public static int Stam { get; set; }
        public static int Oxygen { get; set; }
        public static int Food { get; set; }
        public static double Weight { get; set; }
        public static int Damage { get; set; }
        public static int Speed { get; set; }
        public static double Torpor { get; set; }

        //Taming
        public static int Kibble { get; set; }
        public static int Mejoberries { get; set; }
        public static int Berries { get; set; }

        //Taming time
        public static string KTime { get; set; }
        public static string MTime { get; set; }
        public static string BTime { get; set; }

        public static TimeSpan Timevariable { get; set; }

        public static TimeSpan KTimespan { get; set; }
        public static TimeSpan MTimespan { get; set; }
        public static TimeSpan BTimespan { get; set; }


        //Stat Calc Combo Items
        public static void Pegomastax()
        {
            Timevariable = new TimeSpan(0, 0, 30);

            //stats
            if (Level > 1)
            {
                Hits = 200 + (40 * (Level-1));
                Stam = 100 + (10 * (Level - 1));
                Oxygen = 150 + (15 * (Level - 1));
                Food = 450 + (45 * (Level - 1));
                Weight = 55 + (1.1 * (Level - 1));
                Damage = 100 + (5 * (Level - 1));
                Speed = 100;
                Torpor = 30 + (1.8 * (Level - 1));

            }
            else
            {
                Hits = 200;
                Stam = 100;
                Oxygen = 150;
                Food = 450;
                Weight = 55;
                Damage = 100;
                Speed = 100;
                Torpor = 30;
            }

            //taming
            if (Level > 1)
            {
                Kibble = 2;
                Mejoberries = 21;
                Berries = 31;

                KTime = "00:00:32";
                MTime = "00:02:07";
                BTime = "00:02:04";

            }
            else
            {
                Kibble = 2;
                Mejoberries = 21;
                Berries = 31;

                KTime = "00:00:32";
                MTime = "00:02:07";
                BTime = "00:02:04";

                KTimespan = TimeSpan.Parse(KTime);
                for (int i = 0; i < Level; i++)
                {
                    KTimespan = (KTimespan + Timevariable); 
                    
                }

                KTime = KTimespan.ToString();
            }

            //end pegomastax
        }

        //end combobox items



    }
}
