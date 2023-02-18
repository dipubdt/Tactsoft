using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class Benefit : BaseEntity
    {

        public  string BenefitName { get; set; }

        public string JobPostId { get; set; }
        public string OtherBenefitTypeId { get; set; }

        public JobPost JobPost { get; set; }

        public OtherBenefitType OtherBenefitType { get; set; }
    }
}
