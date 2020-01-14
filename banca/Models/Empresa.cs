using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace banca.Models
{
    public class Empresa
    {
        private string EmpCodigo { get; set; }
        private string EmpNombre { get; set; }
        private string EmpLeyenda { get; set; }
        private string EmpDescripcion { get; set; }
    }

    public class EmpresaDBContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
    }
}