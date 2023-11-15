using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiMotorcycle.Model;
using Microsoft.EntityFrameworkCore;

namespace apiMotorcycle.Context
{
    public class EmpresaContext : DbContext
    {
        public  EmpresaContext(DbContextOptions options) : base(options) {}

        public DbSet<Empresas>? Empresa { get; set; }
    }
}