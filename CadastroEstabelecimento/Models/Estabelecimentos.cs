
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroEstabelecimento.Models
{
    public class Estabelecimentos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Razão Social obrigatório")]
        public string Razao { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo CNPJ obrigatório")]

        public string Cnpj { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Digite um email Válido")]
        public string Email { get; set; }

        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Data Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }

        public bool Status { get; set; }

        [Display(Name = "Categoria")]
        public Categorias Categorias { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriasId { get; set; }

        public Estabelecimentos()
        {

        }

        public Estabelecimentos(int id, string razao, string nome, string cnpj, string email, string endereco, string cidade, string estado, string telefone, DateTime dataCadastro, string agencia, string conta, Boolean status, Categorias categorias)
        {
            Id = id;
            Razao = razao;
            Nome = nome;
            Cnpj = cnpj;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            DataCadastro = dataCadastro;
            Agencia = agencia;
            Conta = conta;
            Status = status;
            Categorias = categorias;
        }
    }
}
