﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(ApplicationUser obj)
        {
            _db.ApplicationUsers.Update(obj);
        }
    }
}
