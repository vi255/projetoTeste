using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetoTeste.Models
{
    public class Funcionario
    {
        [Key]

        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Funcionário")]
        [StringLength(100, ErrorMessage = "O Tamanho Máximo de caracteres é {1}", MinimumLength = 10)]

        public string Sobrenome { get; set; }

        public string EndRua { get; set; }

        public string EndNumero { get; set; }

        public string EndBairro { get; set; }

        public string EndCidade { get; set; }

        public string EndEstado { get; set; }

        public string EndPais { get; set; }
        
    }
}
