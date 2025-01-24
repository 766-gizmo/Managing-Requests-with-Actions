namespace WebApplication2
{
	public class Request
	{
		public int Id { get; set; }
		public int RequestId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }

		// Foreign Key
		public int UserId { get; set; }

		public Users User { get; set; }
		public ICollection<Action> Actions { get; set; }
	}
}
