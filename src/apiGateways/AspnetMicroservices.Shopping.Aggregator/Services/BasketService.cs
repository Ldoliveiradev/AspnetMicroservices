﻿using AspnetMicroservices.Shopping.Aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetMicroservices.Shopping.Aggregator.Services
{
    public class BasketService : IBasketService
    {
        public Task<BasketModel> GetBasket(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
