using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Models
{
    public class Natif: AbstractDefinition
    {
        public override BagageDefinition GetBagage(int idBagage)
        {
            return new BagageDefinition() { CodeIata = "2452637", Compagnie = "LH" };
        }

        public override List<BagageDefinition> GetBagage(string codeIataBagage)
        {
            List<BagageDefinition> bags = new List<BagageDefinition>();
            bags.Add(new BagageDefinition() { CodeIata = "2452637", Compagnie = "LH" });
            return bags;
        }
    }
}
