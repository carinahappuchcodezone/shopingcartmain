﻿using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.Services
{
    public class ShoppersManager: IRepository<Shopper>
    {
        private readonly ShoppingCartDbContext _dbContext;
        public ShoppersManager(ShoppingCartDbContext dbContext )
        {
            this._dbContext = dbContext;

        }

        public bool Add(Shopper t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shopper> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shopper> GetAllShopper() {
            return null;
        }

        public Shopper GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
