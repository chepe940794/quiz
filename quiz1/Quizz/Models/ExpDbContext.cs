using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Quizz.Models
{
    public class ExpDbContext : DbContext
    {
        public DbSet Exp { get; set; }

        public System.Data.Entity.DbSet<Quizz.Models.ExpModel> ExpModels { get; set; }

        public System.Data.Entity.DbSet<Quizz.Models.LenguajeModel> LenguajeModels { get; set; }
    }
}