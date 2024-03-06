using eCommerce.API.Models;
using eCommerce.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private IUserRepository _repository;
		public UserController()
		{
			_repository = new UserRepository();
		}

		[HttpGet]
		public IActionResult ListAll()
		{
			return Ok(_repository.ListAll());
		}

		[HttpGet("{id}")]
		public IActionResult SearchById(int id)
		{
			var user = _repository.SearchById(id);

			if (user == null)
			{
				return NotFound(); //ERRO HTTP: 404 - Not Found
			}

			return Ok(user);
		}

		[HttpPost]
		public IActionResult Create([FromBody] User user)
		{
			_repository.Create(user);
			return Ok(user);
		}
		[HttpPut]
		public IActionResult Update([FromBody] User user)
		{
			_repository.Update(user);
			return Ok(user);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_repository.Delete(id);
			return Ok();
		}
	}
}
