using CadastroEstabelecimento.Data;
using CadastroEstabelecimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstabelecimento.Services
{
    public class CategoriasServices
    {
        private readonly CadastroEstabelecimentoContext _context;

        public CategoriasServices(CadastroEstabelecimentoContext context)
        {
            _context = context;
        }

        public List<Categorias> FindAll()
        {
            return _context.Categorias.OrderBy(x => x.CategoriaDescricao).ToList();
        }

    }
}
