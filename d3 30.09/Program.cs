using d3_30._09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace d3_30._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Завдання 1 ");
            Money Dollars= new Money(75,35, "USD"); Dollars.Show();

            Money Euro = new Money(100, 35, "EUR"); Euro.Show();

            Money Hryvnia = new Money(45, 50, "UAH"); Hryvnia.Show();

            Product Coffe = new Product($"Saeco :",555,40,"UAH");Coffe.Show();

            Coffe.DawnPrice(10); Coffe.Show();

            Coffe.DawnPrice(13.47); Coffe.Show();

            Coffe.DawnPrice(560.35); Coffe.Show();

            Console.WriteLine(" Завдання 2 ");
            Device kettel = new Kettle("Чайник", "Гріє воду");
            kettel.Show();kettel.Desk();kettel.Sound();

            Device microwave = new Microwave("Мікрохвильовка LG ", "Пристрій для приготування та нагрівання Їжі");
                microwave.Show(); microwave.Desk();microwave.Sound();

            Device auto = new Auto("Toyota Camry 3.5", "Японці вже не роблять гарні речі(( Toyota ломається!!!))");
            auto.Show();auto.Desk();auto.Sound();

            Device steamer = new Steamer("Titanic", "Його исторію знають всі! ");
            steamer.Show();steamer.Desk();  steamer.Sound();

            Console.WriteLine(" Завдання 3 ");
            Violin violin = new Violin("Скрипка ", "Струнний музичний смичковий інструмент.", " З'явився у середині XVI століття.") ;
            violin.Show();violin.Desc();violin.Sound();violin.History();

            Trombone trombone = new Trombone("Тромбо́н ", " музичний інструмент сімейства мідних духових.", "Поява тромбона відноситься до XV століття");
            trombone.Show(); trombone.Desc();trombone.Sound();trombone.History();

            Ukulele ukulele = new Ukulele("Name ", "Desc ", "Hist ");
            ukulele.Show();ukulele.Desc(); ukulele.Sound();ukulele.History();

            Cello cello = new Cello(" Cello name...", " Cello desc....", "Cello History....");
            cello.Show();cello.Desc();cello.Sound();cello.History();

            Console.WriteLine();
            Console.WriteLine(" Завдання 4 ");
            President president = new President();
            president.Print();

            Manager manager = new Manager();
            manager.Print();

            Security security = new Security();
            security.Print();

            Engineer engineer = new Engineer();
            engineer.Print();

            Console.WriteLine();
        }
    }
}
