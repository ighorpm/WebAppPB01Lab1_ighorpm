using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPB01Lab1_ighorpm.Models
{
    public class Cliente
    {   
        
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(200, ErrorMessage = "Maximo é 300 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        [StringLength(14, ErrorMessage = "Maximo é 14 caracteres")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        [StringLength(100, ErrorMessage = "Maximo é 100 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Data é obrigatório")]
        public DateTime DataCadastrada { get; set; }

    }
}
