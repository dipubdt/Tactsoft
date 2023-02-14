﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.EntityConfigurations
{
    public class JobSubCategoryConfiguration : IEntityTypeConfiguration<JobSubCategory>



    {

        public void Configure(EntityTypeBuilder<JobSubCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.JobCategory).WithMany(x => x.JobSubCategorys).HasForeignKey(x => x.JobCategoryId);

        }
    }
}
