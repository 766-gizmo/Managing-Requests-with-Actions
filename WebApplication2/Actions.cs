namespace WebApplication2
{
	public class Actions
	{
		public int Id { get; set; }                // Primary Key
		public int RequestId { get; set; }        // Foreign Key(request)
		public int AssignedToUserId { get; set; } // Foreign Key(user)
		public string Note { get; set; }          
		public string DocumentPath { get; set; }   
		public DateTime CreatedAt { get; set; }    

		// Navigation Properties
		public Request Request { get; set; }       
		public Users AssignedToUser { get; set; }
	}
}
