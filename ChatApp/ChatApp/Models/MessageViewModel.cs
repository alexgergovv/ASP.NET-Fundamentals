namespace ChatApp.Models
{
	public class MessageViewModel
	{
		/// <summary>
		/// Message Sender
		/// </summary>
		public string Sender { get; set; } = null!;
		/// <summary>
		/// Text Message
		/// </summary>
		public string MessageText { get; set; } = null!;
    }
}
