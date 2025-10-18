using System.Text.Json.Serialization;

namespace HNG_Stage_Zero_Task.Models
{
	public class CatFactResponse
	{
		[JsonPropertyName("fact")]
		public string Fact { get; set; }
	}
}
