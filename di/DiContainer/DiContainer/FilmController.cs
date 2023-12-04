using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer
{
    internal class FilmController
    {
        private readonly IFilmRepository _filmRepository;

        public FilmController(IFilmRepository filmRepository)
        {
            this._filmRepository = filmRepository;
        }

        public FilmController()
        {
            this._filmRepository = new DummyFilmRepository();
        }

        public void List()
        {
            foreach(var film in _filmRepository.Films)
            {
                Console.WriteLine(film);
            }
        }
    }
}
