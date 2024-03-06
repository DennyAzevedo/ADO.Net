namespace eCommerce.API.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Phone { get; set; }
		public string Cell { get; set; }
		public User User { get; set; }
	}
}
