using System;
using K101MovieApp.Business.Abstract;

namespace K101MovieApp.Business.Concrete
{
    public class FilmManager : IFilmService
    {
        public string Hello()
        {
            return "Hello K101";
        }
    }
}

