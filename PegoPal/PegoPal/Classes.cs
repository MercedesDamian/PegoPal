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

        public static int Hits { get; set; }
        public static int Stam { get; set; }
        public static int Oxygen { get; set; }
        public static int Food { get; set; }
        public static double Weight { get; set; }
        public static int Damage { get; set; }
        public static int Speed { get; set; }
        public static double Torpor { get; set; }

        public static int Level = 1;

        //Course Descriptions for CourseInfo Page

        public static void Pegomastax()
        {

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
        }


    }
}
