using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetoTeste.Models
{
    public class Empresa
    {
        [Key]

        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = "Digite o Nome Fantasia da Empresa")]
        [StringLength(100, ErrorMessage = "O Tamanho Máximo de caracteres é {1}", MinimumLength = 10)]
        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string EndRua { get; set; }

        public int EndNumero { get; set; }

        public string EndBairro { get; set; }

        public string EndCidade { get; set; }

        public string EndEstado { get; set; }

        public string EndPais { get; set; }


    }
}
