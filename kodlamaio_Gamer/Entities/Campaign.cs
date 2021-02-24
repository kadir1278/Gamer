using kodlamaio_Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public double Discount { get; set; }
    }
}
