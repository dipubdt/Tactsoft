using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public  class JobPost : BaseEntity
    {

        public string JobPostTitle { get; set; }


        public IList<Benefit> Benefits { get; set; }
    }

}
