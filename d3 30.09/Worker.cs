using d3_30._09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створити абстрактний базовий клас Worker (працівник)
з методом Print(). Створіть чотири похідні класи: President,
Security, Manager, Engineer. Перевизначте метод.
Print() для виведення інформації, яка відповідає кож-
ному типу працівника.*/

namespace d3_30._09
{
    internal abstract class Worker
    {
        public abstract void Print();
    }
    class President : Worker { 
    
        public override void Print() { Console.WriteLine(" This is class President : Worker "); }
    
    }

    class Security: Worker
    {

    public override void Print() { Console.WriteLine("This is class Security : Worker  "); }
    
    }
    class Manager : Worker
    {

        public override void Print() { Console.WriteLine("This is class Manager : Worker "); }

    }
    class Engineer : Worker
    {

        public override void Print() { Console.WriteLine("This is class Engineer : Worker "); }

    }

}
