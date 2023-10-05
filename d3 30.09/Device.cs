using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Завдання 2
//Створити базовий клас «Пристрій» і похідні класи:
//«Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
//За допомогою конструктора, встановити назву до кожного
//пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук пристрою (пишемо текстом у
//консоль);
//■ Show — відображає назву пристрою;
//■ Desc — відображає опис пристрою

namespace d3_30._09
{
    internal class Device
    {
        protected string  _Nm { get; set; }
        protected string  _Ds { get; set; }
       
        public Device(string name, string desk ) {_Nm= name; _Ds= desk;}

        public virtual void Sound() {Console.WriteLine("звук пристрою");}
        public  void Show() {Console.WriteLine($"назвa пристрою:{_Nm}");}
        public  void Desk() {Console.WriteLine($"опис пристрою:{_Ds}");}

    }


    class Kettle:Device
    { public Kettle(string name, string desk )
            : base(name, desk ) { }
        public override void Sound()
        {
            Console.WriteLine(" Свистить "); 
        }
    }

    class Microwave:Device
    { public Microwave(string name, string desk)
            : base(name, desk) { }
        public override void Sound()
        {
            Console.WriteLine(" Гудить та дзинькає))");
        }

    }
    class Auto : Device
    {
        public Auto(string name, string desk)
            : base(name, desk) { }
        public override void Sound()
        {
            Console.WriteLine(" Біп-Біп)) ");
        }

    }
    class Steamer : Device
    {
        public Steamer(string name, string desk)
            : base(name, desk) { }
        public override void Sound()
        {
            Console.WriteLine(" Буль-Буль)) ");
        }

    }
}
