using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Запрограмуйте клас Money (об'єкт класу оперує однією
валютою) для роботи з грошима.
У класі мають бути передбачені: поле для зберігання
цілої частини грошей (долари, євро, гривні тощо) і поле
для зберігання копійок (центи, євроценти, копійки тощо)
Реалізувати методи виведення суми на екран, задання
значень частин.
На базі класу Money створити клас Product для роботи
з продуктом або товаром. Реалізувати метод, який дозволяє
зменшити ціну на задане число.
Для кожного з класів реалізувати необхідні методи і
поля.*/

namespace d3_30._09
{
    internal class Money
    {
        public int _Wpart { get; set; }
        public int _Dcimal { get; set; }
        public string _Currency { get; set; }
        public Money(int wpart,int dcimal, string currency) {
        
        _Wpart= wpart;
            _Dcimal= dcimal;
        _Currency= currency;
        }
       public virtual void Show() {
            Console.WriteLine($" {_Wpart},{_Dcimal} {_Currency}");
        }

        public virtual void DawnPrice(dynamic _Amotion)
        {
            if (_Amotion is int intAmotion)
            {
                DawnPrice(intAmotion);
            }
            else if (_Amotion is double doubleAmotion)
            {
                DawnPrice(doubleAmotion); 
            }
            else
            {
                throw new ArgumentException("ERRORRR!!! На це зменшити неможливо!!!");
            }
        }
        private void DawnPrice(int _Amotion) {
          
            if (_Wpart >= _Amotion)
            {
                _Wpart -= _Amotion;
               

            }
            else {
                _Wpart = 0;
                _Dcimal = 0;    
            }
        }

        private void DawnPrice(double _Amotion) {
            double doubleSum = (_Wpart + (_Dcimal / 100));
            if (doubleSum >= _Amotion) { 
             doubleSum-= _Amotion;
                _Wpart = (int)doubleSum;
                _Dcimal=(int)((doubleSum-_Wpart)*100);
            }
            else
            {
                _Wpart = 0;
                _Dcimal = 0;
            }
        
        
        }
    }
    class Product: Money
    {
        public string _NameProduct { get; set; }
    public Product(string NameProduct, int _Wpart, int _Dcimal, string _Currency)
        : base(_Wpart, _Dcimal, _Currency) { _NameProduct = NameProduct; }

    public override void Show()
    {
        Console.Write($"{_NameProduct}");
        base.Show();
    }

}
}

