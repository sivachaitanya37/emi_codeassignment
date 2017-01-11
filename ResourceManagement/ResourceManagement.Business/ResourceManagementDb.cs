﻿using ResourceManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceManagement.Core.Models;

namespace ResourceManagement.Business
{
    public class ResourceManagementDb : DbContext, IDbContext
    {
        public void Delete<T>(T ent) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQuery<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T ent) where T : class
        {
            Entry(ent).State = EntityState.Modified;
        }
    }
}