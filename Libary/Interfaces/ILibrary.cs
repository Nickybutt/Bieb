using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Interfaces
{
    public interface ILibrary : IIdentifiable
    {
        string Name { get; set; }
    }
}
