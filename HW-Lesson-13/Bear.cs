using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13
{
    class Bear : IAnimal, IMakeSoundable
    {
        public void Eat()
        {
            Console.WriteLine("*chewing* then swallow");
        }

        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("Roar !!");
        }

        public void Move()
        {
            Console.WriteLine("*walking*");
        }

        public void Sleep()
        {
            Console.WriteLine("I'll see you after the winter");
        }
    }
}
