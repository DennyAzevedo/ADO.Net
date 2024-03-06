namespace eCommerce.API.Models
{
	public class DeliveryAddress
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string AddressName { get; set; }
		public string CEP { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string District { get; set; }
		public string Street { get; set; }
		public string Number { get; set; }
		public string Complement { get; set; }

		public User User { get; set; }
	}
}
