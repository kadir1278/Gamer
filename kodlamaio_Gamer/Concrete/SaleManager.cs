using kodlamaio_Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add()
        {
            Console.WriteLine("Satış Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Satış Kaldırıldı");
        }

        public void Get()
        {
            Console.WriteLine("Satış Getirildi");
        }

        public void Update()
        {
            Console.WriteLine("Satış Güncellendi");
        }
    }
}
