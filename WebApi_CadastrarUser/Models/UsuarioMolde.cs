using System.ComponentModel.DataAnnotations;
using WebApi_CadastrarUser.Enuns;

namespace WebApi_CadastrarUser.Models
{
    public class UsuarioModel
    {
        [Key]
        public int ID { get; set; }
        public String Nome { get; set; }
        public int CPF { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
