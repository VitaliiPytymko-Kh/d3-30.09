using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

/*Створити базовий клас «Музичний інструмент» і похідні
класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
допомогою конструктора, встановити назву до кожного
музичного інструменту і його характеристики.
Реалізуйте для кожного з класів методи:
■ Sound — видає звук музичного інструменту (пишемо
текстом у консоль);
■ Show — відображає назву музичного інструменту;
■ Desc — відображає опис музичного інструменту;
■ History — відображає історію створення музичного
інструменту.*/

namespace d3_30._09
{
    internal class MusicInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Hist { get; set; }
        public MusicInstrument(string name,string desc) {
        Name = name;
            Description = desc;
            Hist = "";

            
        }

        public virtual void Sound() { Console.Write("звук інструменту :");}
        public void Show() { Console.WriteLine($"Назва Інструменту :{Name}"); }
        public  void Desc() { Console.WriteLine($"Oпис музичного інструменту:{Description}"); }
        public  void History() { Console.Write($"Історія створення музичного інструменту:{Hist}"); }
    
    }
    class Violin: MusicInstrument
    {
        public Violin(string name, string desc, string hist): base(name, desc) { Hist = hist; }
        public override void Sound()
        {base.Sound();
            Console.WriteLine("Звук скрипки!"); 
        }
       
    }
    class Trombone : MusicInstrument
    {
        
        public Trombone(string name, string desc, string hist) : base(name, desc) { Hist = hist; }
        public override void Sound()
        {
            Console.WriteLine("Звук тромбону!"); 
        }
        
    }
    class Ukulele : MusicInstrument
    {
       
        public Ukulele(string name, string desc, string hist) : base(name, desc) { Hist = hist; }
        public override void Sound()
        {
            Console.WriteLine("Звук Ukulele!");
        }
        
    }
    class Cello : MusicInstrument
    {
      
        public Cello(string name, string desc, string hist) : base(name, desc) { Hist = hist; }
        public override void Sound()
        {
            Console.WriteLine("Звук Cello!");
        }
        
    }
}
