using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoTeste.Models
{
    public class Funcionario
    {
        [Key]

        public int IdFuncionario { get; set; }

        public int EmpresaId { get; set; }
        [ForeignKey("EmpresaId")]

        public Empresa Empresa { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Funcionário")]
        [StringLength(100, ErrorMessage = "O Tamanho Máximo de caracteres é {1}", MinimumLength = 1)]

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [DisplayName("Rua")]
        public string EndRua { get; set; }

        [DisplayName("Número")]
        public string EndNumero { get; set; }

        [DisplayName("Bairro")]
        public string EndBairro { get; set; }

        [DisplayName("Cidade")]
        public string EndCidade { get; set; }

        [DisplayName("Estado")]
        public string EndEstado { get; set; }

        [DisplayName("País")]
        public string EndPais { get; set; }

        
    }
}
