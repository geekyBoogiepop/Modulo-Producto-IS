using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modulo_Producto.Models;

namespace Modulo_Producto.Data
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext (DbContextOptions<SQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<Modulo_Producto.Models.Producto> Producto { get; set; } = default!;
    }
}
