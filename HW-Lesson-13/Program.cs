using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear b = new Bear();
            Snake s = new Snake();
            Fish f = new Fish();

            AnimalIsHungry(b);
            AnimalIsHungry(s);
            AnimalIsHungry(f);

            AnimalIsTired(b);
            AnimalIsTired(s);
            AnimalIsTired(f);

            b.Move();
            s.Move();
            f.Move();

            Console.ReadLine();
        }
        public static void AnimalIsHungry(IAnimal ani)
        {
            if (ani is IMakeSoundable)
            {
                (ani as IMakeSoundable).MakeSoundBeforeEating();
            }
            ani.Eat();
        }
        public static void AnimalIsTired(IAnimal ani)
        {
            ani.Sleep();
        }
    }
}
