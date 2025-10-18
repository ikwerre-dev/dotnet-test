namespace HNG_Stage_Zero_Task.Models
{
	public class ProfileResponse
	{
		public string Status { get; set; } = "Success";
		public User User { get; set; }
		public string TimeStamp { get; set; }
		public string Fact { get; set; }
	}
}
