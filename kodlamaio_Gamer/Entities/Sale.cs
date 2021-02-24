using kodlamaio_Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Entities
{
    public class Sale:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CustomerId { get; set; }
    }
}
