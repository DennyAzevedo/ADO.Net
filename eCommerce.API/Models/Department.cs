﻿namespace eCommerce.API.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
