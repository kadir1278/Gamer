using kodlamaio_Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
        void Get(Customer customer);
    }
}
