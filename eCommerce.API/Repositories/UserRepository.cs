using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
	public class UserRepository : IUserRepository
	{
		private static List<User> _db = new List<User>()
		{
			new User(){ Id=1, Name="Filipe Rodrigues", Email="filipe.rodrigues@gmail.com" },
			new User(){ Id=2, Name="Marcelo Rodrigues", Email="marcelo.rodrigues@gmail.com"},
			new User(){ Id=3, Name="Jessica Rodrigues", Email="jessica.rodrigues@gmail.com"}
		};
		public List<User> ListAll()
		{
			return _db;
		}

		public User SearchById(int id)
		{
			return _db.FirstOrDefault(a => a.Id == id);
		}

		public void Create(User user)
		{
			var lastUser = _db.LastOrDefault();

			if (lastUser == null)
			{
				user.Id = 1;
			}
			else
			{
				user.Id = lastUser.Id;
				user.Id++;
			}
			_db.Add(user);
		}

		public void Update(User user)
		{
			_db.Remove(_db.FirstOrDefault(a => a.Id == user.Id));
			_db.Add(user);
		}

		public void Delete(int id)
		{
			_db.Remove(_db.FirstOrDefault(a => a.Id == id));
		}
	}
}
