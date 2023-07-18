﻿using System;
namespace K101MovieApp.Entities.Concrete
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
	}
}

