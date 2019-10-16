using Election.Calculator.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Election.Calculator.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ReturnListOfLists()
		{
			var voteResult = new VotingResult()
			{
				Constituencies =
				{
					new Constituency("1", 1000, 900)
					{
						Votes =
						{
							new Vote("1",400),new Vote("1")
						}
					}
				}
			}
		}
	}
}
