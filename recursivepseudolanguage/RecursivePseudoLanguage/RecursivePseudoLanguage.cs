using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using SystemX;
using String = SystemX.String;

namespace RecursivePseudoLanguage
{
	// Esta clase solo deberá contener el texto parseado con parentesis corchetes y llaves, pero sin parseo de ningun otro tipo.
	//TODO:Cambiar de nombre la clase, este no va a ser un parser, solamente va a hacer substituciones de texto
	public class RecursivePseudoLanguage
	{
		public RecursivePseudoLanguage ( )
		{
		}

		public static ReplaceableString Parse(string text)
		{
			ReplaceableString result = new ReplaceableString();

			ReplaceableString substitution = new ReplaceableString (text);

			substitution = new Bracket().replace ( substitution );

			substitution = new Parenthesis().replace ( substitution );

			substitution = new Brace().replace ( substitution );

			substitution = new Protocol().replace ( substitution );

			substitution = new Implementation().replace ( substitution );

			substitution = new Interface().replace ( substitution );

			result = substitution;
			return result;
		}

		public static ReplaceableString ParseV2(string text)
		{
			ReplaceableString result = new ReplaceableString(text);
			
			InnerElement  []innerElements= {
				new Bracket(),
				new Parenthesis(), 
				new Brace(), 
				//new Protocol(),
				//new Implementation(),
				//new Interface()
			};
			
			while( thereAreElements( result.text, innerElements )  )
			{
				
				foreach( InnerElement innerElement in innerElements )
				{
					if( thereAreElements(  result.text, innerElement.InnerPattern ) )
					{
						Match match =  findInner(  result.text, innerElement.InnerPattern );
						
						if( ! thereAreElements( match.Value.Substring(1,match.Value.Length-1), innerElements ) )
						{
							string newText =  " _"+ innerElement.GetType().Name +  "_ " ;
							
							result.Replace(match.Index,match.Length,newText);
						}
					}
				}
			}
			
			return result;
		}
		
		public static InnerElement [] ArrayExcept(  InnerElement  []innerElements , InnerElement innerElement )
		{
			List<InnerElement> resultList = new List<InnerElement>(innerElements);
			
			resultList.Remove(innerElement);
			
			return resultList.ToArray();
		}
		
		//TODO: pasar esto a un método estático.
		public static  Match findInner( string text , string pattern)
		{
			Match result = null;

			//string pattern = InnerPattern;
			RegexOptions options = RegexOptions.Singleline;
			Regex regex = new Regex (pattern,options);
			Match match = regex.Match (text);

			if (match.Success) {
				result =  match;
			}

			return result;
		}
		
		public static bool thereAreElements( string text, InnerElement  []innerElements )
		{
			foreach( InnerElement innerElement in innerElements )
			{
				if( thereAreElements(  text, innerElement.InnerPattern ) )
					return true;
			}
			return false;
		}
		
		
		
		public  static bool thereAreElements( string text, string pattern )
		{
			bool result = false;

			Match match = findInner (text, pattern);
			result = match != null && match.Success;

			return result;
		}

	}
}

