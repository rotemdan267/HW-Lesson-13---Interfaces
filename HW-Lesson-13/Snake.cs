using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13
{
    class Snake : IAnimal, IMakeSoundable
    {
        public void Eat()
        {
            Console.WriteLine("*swallowing without chewing*");
        }

        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("  Hiss ...");
        }

        public void Move()
        {
            Console.WriteLine("*slithering*");
        }

        public void Sleep()
        {
            Console.WriteLine("zZzZZzzZzZz...");
        }
    }
}
