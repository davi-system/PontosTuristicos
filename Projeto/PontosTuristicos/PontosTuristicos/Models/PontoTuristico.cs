using System;

namespace PontosTuristicos.Models
{
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public int Estado { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        

        public PontoTuristico()
        {
        }       
    }
}
