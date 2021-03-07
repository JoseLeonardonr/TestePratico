using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstabelecimento.Models.ViewModels
{
    public class EstabelecimentosFormViewModel
    {
        public Estabelecimentos Estabelecimentos { get; set; }

        public ICollection<Categorias> Categorias { get; set; }
    }
}
