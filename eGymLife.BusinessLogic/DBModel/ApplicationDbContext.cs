using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eGymLife.Domain.Entities.User;
using eGymLife.Domain.Entities;

namespace eGymLife.BusinessLogic.DBModel
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
            base("name = eGymLife")
        {
        }
        public DbSet<UDbTable> UDbTable { get; set; }

    }


}


