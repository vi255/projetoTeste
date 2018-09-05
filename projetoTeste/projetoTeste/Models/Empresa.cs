using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [StringLength(100, ErrorMessage = "O Tamanho Máximo de caracteres é {1}", MinimumLength = 1)]

        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        [DisplayName("Rua")]
        public string EndRua { get; set; }

        [DisplayName("Número")]
        public int EndNumero { get; set; }

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
