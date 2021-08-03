using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13
{
    class Fish : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("yam yam");
        }

        public void Move()
        {
            Console.WriteLine("*swimming*");
        }

        public void Sleep()
        {
            Console.WriteLine("*not closing my eyes* \n ZzZzZzZz....");
        }
    }
}
