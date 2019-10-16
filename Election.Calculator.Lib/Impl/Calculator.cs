using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Election.Calculator.Model;

namespace Election.Calculator.Lib.Impl
{
	public class Calculator : ICalculator
	{
		private CalculatorConfiguration configuration = CalculatorConfiguration.Default;

		public void Calculate<T>(T methodInstance, VotingResult result) where T : IMethod
		{
			List<string> allLists = configuration.Parties
				.Concat(configuration.Coalition)
				.Concat(configuration.NationalMinority)
				.ToList();
			var totalVotes = result.Constituencies.Sum(c => c.Voted);
			foreach (var list in allLists)
			{
				int listResult = result.Constituencies.Sum(t => t.Votes.Where(v => v.List == list).Sum(v => v.ReceivedVotes));
				decimal percentResult = (1m * listResult) / totalVotes;
			}
		}

		public ICalculator Configure(CalculatorConfiguration config)
		{
			configuration = config;
			return this;
		}
	}
}
