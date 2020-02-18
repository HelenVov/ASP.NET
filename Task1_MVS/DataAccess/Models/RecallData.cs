using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class RecallData :BaseEntity
    {
        public string RecallDataName { get; set; }

        public DateTime RecallDataTime { get; set; }

        public string RecallDataText { get; set; }
    }
}
