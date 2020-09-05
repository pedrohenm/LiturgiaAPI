using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiturgiaAPI.Models
{
    public class LiturgiaModel
    {
        public string TempoLiturgico { get; set; }
        public string Cor { get; set; }
        public LeituraModel Leitura { get; set; }
        public SalmoModel Salmo { get; set; }
        public EvangelhoModel Evangelho { get; set; }

    }
}
