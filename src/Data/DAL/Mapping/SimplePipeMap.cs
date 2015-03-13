﻿using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;
using Prizm.Domain.Entity;
using System;
using Prizm.Domain.Entity.SimpleReleaseNote;

namespace Prizm.Data.DAL.Mapping
{
    public class SimplePipeMap : ClassMap<SimplePipe>
    {
        public SimplePipeMap()
        {
            Table("Pipe");
            #region --- Map ---
            Id(x => x.Id).Column("id").GeneratedBy.Guid();
            Map(_ => _.ToExport).Column("ToExport");
            #endregion

            #region --- References ---
            References<Railcar>(x => x.Railcar).Column("railcarId").Cascade.SaveUpdate();
	        References<PipeMillSizeType>(x => x.Type).Column("typeId");
            #endregion

            #region --- HasMany ---
            HasMany<File>(x => x.Attachments).KeyColumn("item").Inverse().LazyLoad();
            #endregion
        }
    }
}