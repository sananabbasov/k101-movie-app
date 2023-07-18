using System;
using K101MovieApp.Core.Entities.Abstract;

namespace K101MovieApp.Entities.Concrete
{
	public class Film : BaseEntity, IEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string PhotoUrl { get; set; }
		public string VideoUrl { get; set; }
		public string CoverUrl { get; set; }
		public int Imdb { get; set; }
		public int View { get; set; }
        public List<Actor> Actors { get; set; }
    }
}

