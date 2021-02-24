using kodlamaio_Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Abstract
{
    public abstract class AbstractCustomerManager
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Giriş Yapan Oyuncu : " + customer.FirstName + " " + customer.LastName);
        }
    }
}
