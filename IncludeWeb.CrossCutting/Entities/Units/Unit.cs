using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncludeWeb.CrossCutting.Entities.Units
{
    public class Unit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CorporationId { get; set; }
    }
}
