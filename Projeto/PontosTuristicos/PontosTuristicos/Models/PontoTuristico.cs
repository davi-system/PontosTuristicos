using System;
using System.ComponentModel.DataAnnotations;

namespace PontosTuristicos.Models
{
    public class PontoTuristico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe uma cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe um estado")]
        [MaxLength(2)]
        [MinLength(2, ErrorMessage = "Informe dois dígitos")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Informe um nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe uma referência")]
        public string Referencia { get; set; }
        [Required(ErrorMessage = "Informe uma descrição")]
        public string Descricao { get; set; }
        

        public PontoTuristico()
        {
        }       
    }
}
