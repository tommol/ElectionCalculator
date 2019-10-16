namespace Election.Calculator.Lib
{
	public class CalculatorConfiguration
	{
		public string[] Parties { get; set; }
		public string[] Coalition { get; set; }
		public string[] NationalMinority { get; set; }

		public decimal PartyThreshold { get; set; } = 5.0m;
		public decimal CoalitionThreshold { get; set; } = 8.0m;
		public decimal NationalMinorityThreshold { get; set; } = 0.0m;

		public static CalculatorConfiguration Default
		{
			get {
				return new CalculatorConfiguration();
			}
		}
	}
}
