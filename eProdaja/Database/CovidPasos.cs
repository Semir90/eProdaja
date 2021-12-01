using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public class CovidPasos
    {
        public CovidPasos()
        {
            Kupcis = new HashSet<Kupci>();
        }

        public int CovidPasosId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string VazeciPasos { get; set; }
        public virtual ICollection<Kupci> Kupcis { get; set; }
    }
}
