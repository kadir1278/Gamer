﻿using kodlamaio_Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio_Gamer.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Price { get; set; }
    }
}
