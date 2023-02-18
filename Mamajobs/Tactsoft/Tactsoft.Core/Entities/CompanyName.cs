using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class CompanyName : BaseEntity
    {

        [Display(Name = "CompanyName English Name")]
        public string CompanyNameEnglishName { get; set; }


        [Display(Name = "CompanyName Bnagla Name")]

        public string CompanyNameBnaglaName { get; set; }



    }
}
