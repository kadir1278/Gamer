using kodlamaio_Gamer.Abstract;
using kodlamaio_Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Concrete
{
    public class CustomerManager:AbstractCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Bilgiler Hatalı");
            }
        }
        public void Add() { Console.WriteLine("Oyuncu Eklendi"); }
        public void Delete() { Console.WriteLine("Oyuncu Silindi"); }
        public void Update() { Console.WriteLine("Oyuncu Güncellendi"); }
        public void Get() { Console.WriteLine("Oyuncu Getirildi"); }


    }
}
