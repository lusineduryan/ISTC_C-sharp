using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class Program
    {
        public static void Say(Interface1 interface1)
        {
            interface1.Voice();
        }
        public static void Step(Interface1 interface2)
        {
            interface2.Move();
        }
        public static void InhaleExhale(Interface2 interface3)
        {
            interface3.Breathe();
        }
        public static void Consider(Interface3 interface4)
        {
            interface4.Think();
        }


        static void Main(string[] args)
        {
            Interface1 human1 = new HumanClass() as Interface1;
            human1.Move();
            human1.Voice();

            Say(human1);

            Interface2 human2 = new HumanClass() as Interface2;
            human2.Breathe();

            Interface3 human3 = new HumanClass() as Interface3;
            human3.Think();

            Interface2 fish1 = new FishClass() as Interface2;
            fish1.Breathe();

            Interface1 cat1 = new CatClass() as Interface1;
            cat1.Move();
            cat1.Voice();

            Say(cat1);

            Interface2 cat2 = new CatClass() as Interface2;
            cat2.Breathe();

            Interface1 robot1 = new RobotClass() as Interface1;
            robot1.Move();
            robot1.Voice();

            Say(robot1);

            Interface3 robot2 = new RobotClass() as Interface3;
            robot2.Think();
            Console.ReadKey();
        }
    }
}
