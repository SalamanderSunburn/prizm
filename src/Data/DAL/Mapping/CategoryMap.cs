﻿using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class CategoryMap : SubclassMap<Category>
    {
        public CategoryMap()
        {
            Map(x => x.Name).Column("name");

            HasMany<PipeTest>(x => x.PipeTests).KeyColumn("categoryId");

        }
    }
}
