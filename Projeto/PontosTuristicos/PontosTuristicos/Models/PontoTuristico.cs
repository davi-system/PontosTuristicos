using System;

namespace PontosTuristicos.Models
{
    public class PontoTuristico
    {
        public int pts_id { get; set; }
        public int pts_cid_fk { get; set; }
        public int pts_est_fk { get; set; }
        public string pts_nome { get; set; }
        public string pts_referencia { get; set; }
        public string pts_descricao { get; set; }
        public DateTime pts_dataCriacao { get; set; }

        public PontoTuristico()
        {
        }       
    }
}
