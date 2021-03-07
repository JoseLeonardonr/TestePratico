using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroEstabelecimento.Models;

namespace CadastroEstabelecimento.Data
{
    public class CadastroEstabelecimentoContext : DbContext
    {
        public CadastroEstabelecimentoContext (DbContextOptions<CadastroEstabelecimentoContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroEstabelecimento.Models.Categorias> Categorias { get; set; }
        public DbSet<CadastroEstabelecimento.Models.Estabelecimentos> Estabelecimentos { get; set; }
        public object StatusEstabelecimento { get; internal set; }
    }
}
