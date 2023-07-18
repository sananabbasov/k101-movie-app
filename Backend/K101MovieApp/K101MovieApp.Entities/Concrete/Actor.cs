using System;
using K101MovieApp.Core.Entities.Abstract;

namespace K101MovieApp.Entities.Concrete
{
	public class Actor : BaseEntity, IEntity
    {
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Character { get; set; }
		public string PhotoUrl { get; set; }
		public List<FilmActor> FilmActors { get; set; }
	}
}

