using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroEstabelecimento.Models
{
    public class Categorias
    {
        
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        public string CategoriaDescricao { get; set; }
        public ICollection<Estabelecimentos> Estabelecimentos { get; set; } = new List<Estabelecimentos>();

        public Categorias()
        {

        }

        public Categorias(int id, string categoriaDescricao)
        {
            Id = id;
            CategoriaDescricao = categoriaDescricao;
        }
    }
}
