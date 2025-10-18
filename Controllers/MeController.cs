using HNG_Stage_Zero_Task.Models;
using HNG_Stage_Zero_Task.Services;
using Microsoft.AspNetCore.Mvc;

namespace HNG_Stage_Zero_Task.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MeController(CatFactService catFactService) : ControllerBase
	{
		[HttpGet]
		public async Task<IResult> me()
		{
			var catFact = await catFactService.GetRandomCatFactAsync();
			var utcNow = DateTime.UtcNow;

			var response = new ProfileResponse
			{
				User = new User
				{
					Name = "Apha-Base",
					Email = "oriolowomustapha@gmail.com",
					Stack = "ASP.NET Core, C#"
				},
				TimeStamp = utcNow.ToString("o"),
				Fact = catFact
			};

			return Results.Ok(response);
		}
	}
}
