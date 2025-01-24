using Azure.Core;

namespace WebApplication2
{
	public class Users
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
		public string Role { get; set; }
		public DateTime CreatedAt { get; set; }

		public ICollection<Request> Requests { get; set; }
		public ICollection<Action> Actions { get; set; }
	}
}
