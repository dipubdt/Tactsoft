﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class ResumeReceivingOption : BaseEntity
    {



        [Required]
        [Display(Name = "ResumeOption Name")]
        public string ResumeOption { get; set; }
    }
}
