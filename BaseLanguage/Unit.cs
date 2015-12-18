using System;

namespace BaseLanguage
{
	public class Unit
	{
		public Unit (  )
		{
		}

		public Unit ( string inputText )
		{
			//Checar que sea un numero
			this.value = inputText;
		}


		public new static Unit parse(string inputText)
		{
//			Unit Unit = new Number(inputText);

			//return Unit;
			return null;
		}

		public string value { get; set;}

		public override string ToString()
		{
			return "" + value;
		}
	}
	public interface IUnit  
	{
		string value { get; set;}
	}
}