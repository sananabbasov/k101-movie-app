using System;
using K101MovieApp.DataAccess.Concrete.EntityFramework;
using K101MovieApp.DataAccess.DataSeeding.Abstract;
using K101MovieApp.Entities.Concrete;

namespace K101MovieApp.DataAccess.DataSeeding.Concrete
{
    public class EfDataSeeder : IDataSeeder
    {
        public void AddData()
        {
            using var context = new AppDbContext();

            List<Actor> actors = new();

            if (!context.Actors.Any())
            {
                actors.Add(new Actor { Name = "Actor1", Surname = "Surname1", Character = "Character1", PhotoUrl = "PhotoUrl1" });
                actors.Add(new Actor { Name = "Actor2", Surname = "Surname2", Character = "Character2", PhotoUrl = "PhotoUrl2" });
                actors.Add(new Actor { Name = "Actor3", Surname = "Surname3", Character = "Character3", PhotoUrl = "PhotoUrl3" });
                actors.Add(new Actor { Name = "Actor4", Surname = "Surname4", Character = "Character4", PhotoUrl = "PhotoUrl4" });
                actors.Add(new Actor { Name = "Actor5", Surname = "Surname5", Character = "Character5", PhotoUrl = "PhotoUrl5" });

                context.Actors.AddRange(actors);
                context.SaveChanges();
            }

            List<Film> films = new();

            if (!context.Films.Any())
            {
                films.Add(new Film { Name = "Film1", Description = "Description1", PhotoUrl = "PhotoUrl1", VideoUrl = "VideoUrl1", CoverUrl = "CoverUrl1", Imdb = 8, View = 100 });
                films.Add(new Film { Name = "Film2", Description = "Description2", PhotoUrl = "PhotoUrl2", VideoUrl = "VideoUrl2", CoverUrl = "CoverUrl2", Imdb = 7, View = 200 });
                films.Add(new Film { Name = "Film3", Description = "Description3", PhotoUrl = "PhotoUrl3", VideoUrl = "VideoUrl3", CoverUrl = "CoverUrl3", Imdb = 6, View = 300 });
                films.Add(new Film { Name = "Film4", Description = "Description4", PhotoUrl = "PhotoUrl4", VideoUrl = "VideoUrl4", CoverUrl = "CoverUrl4", Imdb = 9, View = 400 });
                films.Add(new Film { Name = "Film5", Description = "Description5", PhotoUrl = "PhotoUrl5", VideoUrl = "VideoUrl5", CoverUrl = "CoverUrl5", Imdb = 8, View = 500 });
                films.Add(new Film { Name = "Film6", Description = "Description6", PhotoUrl = "PhotoUrl6", VideoUrl = "VideoUrl6", CoverUrl = "CoverUrl6", Imdb = 7, View = 600 });
                films.Add(new Film { Name = "Film7", Description = "Description7", PhotoUrl = "PhotoUrl7", VideoUrl = "VideoUrl7", CoverUrl = "CoverUrl7", Imdb = 9, View = 700 });
                context.Films.AddRange(films);
                context.SaveChanges();
            }
          

            if (!context.FilmActors.Any())
            {
                List<FilmActor> filmActors = new();
                filmActors.Add(new FilmActor { ActorId = actors[0].Id, FilmId = films[0].Id });
                filmActors.Add(new FilmActor { ActorId = actors[0].Id, FilmId = films[1].Id });
                filmActors.Add(new FilmActor { ActorId = actors[0].Id, FilmId = films[2].Id });
                filmActors.Add(new FilmActor { ActorId = actors[3].Id, FilmId = films[2].Id });
                filmActors.Add(new FilmActor { ActorId = actors[1].Id, FilmId = films[4].Id });
                filmActors.Add(new FilmActor { ActorId = actors[1].Id, FilmId = films[1].Id });

                context.FilmActors.AddRange(filmActors);
                context.SaveChanges();
            }

        }
    }
}

