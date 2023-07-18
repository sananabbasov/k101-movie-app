using System;
using K101MovieApp.Core.DataAccess.EntitiyFramework;
using K101MovieApp.DataAccess.Abstract;
using K101MovieApp.Entities.Concrete;

namespace K101MovieApp.DataAccess.Concrete.EntityFramework
{
	public class EfFilmDal : EfRepositoryBase<Film,AppDbContext>, IFilmDal
	{
	}
}

