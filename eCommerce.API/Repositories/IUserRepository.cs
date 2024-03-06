using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
	public interface IUserRepository
	{
		public List<User> ListAll();
		public User SearchById(int id);
		public void Create(User user);
		public void Update(User user);
		public void Delete(int id);
	}
}
