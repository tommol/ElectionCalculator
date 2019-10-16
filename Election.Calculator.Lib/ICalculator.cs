using Election.Calculator.Model;
using System;
using System.Collections.Generic;

namespace Election.Calculator.Lib
{
	public interface ICalculator
	{
		ICalculator Configure(CalculatorConfiguration config);
		void Calculate<T>(T methodInstance, VotingResult result) where T : IMethod;
	}
}
