using kodlamaio_Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Get()
        {
            Console.WriteLine("Kampanya Getirildi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
