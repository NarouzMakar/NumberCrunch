﻿using Experity.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.EntityConfigurations
{
    internal abstract class AggregateRootConfiguration<T> : IEntityTypeConfiguration<T>
                                                                     where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            //Base Configuration
        }

    }
}
