using System;

namespace LanguageConverter
{
	public static class LanguageConverter
	{
		
		public static string ObjectiveCToCSharp(string inputCode)
		{
			string result = "";
			//ObjectiveC.Unit objectiveCUnit = ObjectiveC.Unit.parse2 (inputCode);
			ObjectiveC.IEvaluableExpression ObjectiveCEvaluableExpression = ObjectiveC.EvaluableExpression.parse (inputCode);

			//CSharp.Unit cSharpUnit = ObjectiveCToCSharp (EvaluableExpression);
			CSharp.IEvaluableExpression CSharpEvaluableExpression = ObjectiveCToCSharp (ObjectiveCEvaluableExpression);

			result = CSharpEvaluableExpression.ToString ();
			return result;
		}

		public static CSharp.IEvaluableExpression ObjectiveCToCSharp(ObjectiveC.IEvaluableExpression objectiveExpression)
		{
			CSharp.IEvaluableExpression CSharpExpression = null;

			//Q&D: en teoría funcionará para la mayoría de las cosas.
			//CSharpUnit = new CSharp.Unit (objectiveCUnit);

			if (objectiveExpression is BaseLanguage.INumber) {

				CSharpExpression = new CSharp.Number ((BaseLanguage.INumber)objectiveExpression);
			}
			if (objectiveExpression is BaseLanguage.IAddition) {

				CSharpExpression = new CSharp.Addition ((BaseLanguage.IAddition)objectiveExpression);
			}

			return CSharpExpression;
		}

//		public static CSharp.Unit ObjectiveCToCSharp(ObjectiveC.Unit objectiveCUnit)
//		{
//			CSharp.Unit CSharpUnit = null;
//
//			//Q&D: en teoría funcionará para la mayoría de las cosas.
//			//CSharpUnit = new CSharp.Unit (objectiveCUnit);
//
//			if (objectiveCUnit is BaseLanguage.INumber) {
//				
//				CSharpUnit = new CSharp.Number (objectiveCUnit);
//			}
//
//			return CSharpUnit;
//		}
	}
}

