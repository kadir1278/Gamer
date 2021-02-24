using kodlamaio_Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
