using System;
using System.Collections.Generic;
using System.Text;

namespace Election.Calculator.Model
{
	public class VotingResult
	{
		public IList<Constituency> Constituencies { get; set; } = new List<Constituency>();
	}
}
