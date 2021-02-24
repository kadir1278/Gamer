using kodlamaio_Gamer.Abstract;
using kodlamaio_Gamer.Adapter;
using kodlamaio_Gamer.Concrete;
using kodlamaio_Gamer.Entities;
using System;

namespace kodlamaio_Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCustomerManager _customerManager = new CustomerManager(new MernisServiceAdapter());
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            GameManager gameManager = new GameManager();
            SaleManager saleManager = new SaleManager();
            #region MernisKontrol
            try
            {
                customerManager.Add(new Customer
                {
                    Id = 1,
                    FirstName = "Kadir",
                    LastName = "Ari",
                    IdentityNumber = 12312312123,
                    DateYear = 1999
                });
            }
            catch 
            {
                Console.WriteLine("Kullanıcı Bulunamadı");                
            }
           
            #endregion
            #region Customer CRUD
            customerManager.Add();
            customerManager.Get();
            customerManager.Delete();
            customerManager.Update();
            #endregion
            Console.WriteLine("-------------------------------");
            #region Game CRUD
            gameManager.Add();
            gameManager.Delete();
            gameManager.Get();
            gameManager.Update();
            #endregion
            Console.WriteLine("-------------------------------");
            #region Sale CRUD
            saleManager.Add();
            saleManager.Delete();
            saleManager.Update();
            saleManager.Get();
            #endregion
            Console.WriteLine("-------------------------------");

            Console.ReadLine();
        }
    }
}
