using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.Domain
{
    public abstract class Entity
    {
        public virtual long Id { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
