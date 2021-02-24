using kodlamaio_Gamer.Abstract;
using kodlamaio_Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Concrete
{
    public class GameManager : IGameService
    {
        public void Add()
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Get()
        {
            Console.WriteLine("Oyun Getirildi");
        }

        public void Update()
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
