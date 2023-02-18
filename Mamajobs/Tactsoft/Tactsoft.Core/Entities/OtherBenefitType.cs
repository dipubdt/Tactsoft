using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class OtherBenefitType : BaseEntity
    {
        public string OtherBenefitTypeName { get; set; }
        public IList<Benefit> Benefits { get; set; }
    }
}
