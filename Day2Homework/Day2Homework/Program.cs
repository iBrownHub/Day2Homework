using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouldering bouldering = new Bouldering();
            Lead lead = new Lead();
            Gym gym = new Gym();
            Climbing[] climbings =
            {
                new Climbing(),
                new Roped(),
                new Bouldering(),
                new Lead()
            };

            climbings[0].PrintGradeStyle();
            climbings[1].PrintGradeStyle();
            climbings[2].PrintGradeStyle();
            climbings[1].Indoor();
            climbings[3].Indoor();
            Console.ReadLine();

        }
    }

    class Climbing
    {
        private bool chalk;
        private string grade;

        public bool Chalk { get => chalk; set => chalk = value; }
        public string Grade { get => grade; set => grade = value; }

        public virtual void PrintGradeStyle()
        {
            Console.WriteLine("the grade style is Font");
        }
        public virtual void Indoor()
        {
            Console.WriteLine("I'm climbing");
        }
    }

    class Roped : Climbing
    {
        private bool rope;
        private bool belayDevice;
        private bool carabiner;

        public bool Rope { get => rope; set => rope = value; }
        public bool BelayDevice { get => belayDevice; set => belayDevice = value; }
        public bool Carabiner { get => carabiner; set => carabiner = value; }

        public override void PrintGradeStyle()
        {
            Console.WriteLine("The grade style is English");
        }
        public override void Indoor()
        {
            Console.WriteLine("I'm climbing indoors");
        }
    }

    class Bouldering : Climbing
    {
        public override void PrintGradeStyle()
        {
            Console.WriteLine("The grade style is V grades");
        }
        private double height;

        public double Height { get => height; set => height = value; }
    }

    class Lead : Roped
    {
        public override void Indoor()
        {
            Console.WriteLine("I'm climbing outdoors");
        }
        private bool quickdraw;

        public bool Quickdraw { get => quickdraw; set => quickdraw = value; }
    }

    class Gym
    {
        private Bouldering bouldering;
        private Lead lead;

        internal Bouldering Bouldering { get => bouldering; set => bouldering = value; }
        internal Lead Lead { get => lead; set => lead = value; }
    }
}
