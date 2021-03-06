﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public class Connector : Item
    {
        public virtual decimal Diameter { get; set; }
        public virtual decimal WallThickness { get; set; }

        public virtual Joint Joint { get; set; }
        public virtual Component Component { get; set; }

        public override string ToString()
        {
            return Convert.ToString(Diameter);
        }

        public virtual bool IsConnected
        {
            get { return this.Joint != null; } 
        }

        public override Guid OwnerId
        {
            get
            {
                return (Component == null) ? this.Id : Component.Id;
            }
            set
            {
                base.OwnerId = value;
            }
        }
    }
}
