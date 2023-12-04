using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer
{
    internal class DummyFilmRepository : IFilmRepository
    {
        private List<Film> films = new List<Film>()
        {
            new Film { Title = "Back to the Future", RunningTime = 100 },
            new Film { Title = "The Lord of the Rings", RunningTime = 180 }
        };
        public IEnumerable<Film> Films { get => films; }
    }
}
