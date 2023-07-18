using System;
using K101MovieApp.Core.Entities.Abstract;

namespace K101MovieApp.Entities.Concrete
{
	public class FilmActor : BaseEntity, IEntity
    {
		public int FilmId { get; set; }
		public Film Film { get; set; }
		public int ActorId { get; set; }
		public Actor Actor { get; set; }
	}
}

