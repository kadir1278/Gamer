using kodlamaio_Gamer.Abstract;
using kodlamaio_Gamer.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    customer.IdentityNumber,
                    Ad: customer.FirstName.ToUpper(),
                    Soyad: customer.LastName.ToUpper(),
                    DogumYili: customer.DateYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
