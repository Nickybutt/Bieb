using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Interfaces
{
    public interface IIdentifiable
    {
        Guid id { get; set; }
    }
}
