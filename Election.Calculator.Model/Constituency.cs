using System;
using System.Collections.Generic;

namespace Election.Calculator.Model
{
	public class Constituency
	{
		public string Id { get; set; }
		public int Voters { get; set; }
		public int Voted { get; set; }
		public IList<Vote> Votes { get; set; } = new List<Vote>();

		public Constituency(string id, int voters, int voted)
		{
			Id = id ?? throw new ArgumentNullException(nameof(id));
			Voters = voters;
			Voted = voted;
		}
	}
}
