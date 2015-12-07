using System;

namespace WindowsFormGUI
{
	public class UnbabelCode
	{
//		public UnbabelCode ()
//		{
//		}

		public static string ObjectiveCToCSharp(string inputCode)
		{
			string result = "test";
			ObjectiveC.Unit objectiveCUnit = ObjectiveC.Unit.parse (inputCode);

			CSharp.Unit cSharpUnit = ObjectiveCToCSharp (objectiveCUnit);

			//result = cSharpUnit.ToString ();
			return result;
		}

		public static CSharp.Unit ObjectiveCToCSharp(ObjectiveC.Unit objectiveCUnit)
		{
			
			return new CSharp.Unit ();
		}

	}
}