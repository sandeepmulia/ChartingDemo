using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Model
{
    /// <summary>
    /// Main Object which represents the commodities queried from database
    /// </summary>
    public class Commodity
    {
        public string CommodityName { get; set; }
        public float PlantedAcreage { get; set; }
        public float HarvestedAcreage { get; set; }
        public float Production { get; set; }
        public float YieldPerAcre { get; set; }
        public float WeightedAvgPrice { get; set; }
        public float LoanRate { get; set; }
        internal DateTime Year { get; set; }
        public int HarvestYear
        {
            get
            {
                return Year.Year;
            }
        }
    }
}
