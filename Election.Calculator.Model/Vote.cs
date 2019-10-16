using System;

namespace Election.Calculator.Model
{
	public class Vote
	{
		public string List { get; set; }
		public int ReceivedVotes { get; set; }

		public Vote(string list, int receivedVotes)
		{
			List = list ?? throw new ArgumentNullException(nameof(list));
			ReceivedVotes = receivedVotes;
		}
	}
}
