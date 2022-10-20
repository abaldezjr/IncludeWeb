using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncludeWeb.CrossCutting.DTOs.Units
{
    public class UnitDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CorporationId { get; set; }
    }
}
