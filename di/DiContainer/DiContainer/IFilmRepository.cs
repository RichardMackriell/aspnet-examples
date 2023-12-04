using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer
{
    internal interface IFilmRepository
    {
        public IEnumerable<Film> Films { get; }
    }
}
