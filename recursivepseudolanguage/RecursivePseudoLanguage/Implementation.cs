﻿using System;

namespace RecursivePseudoLanguage
{
	public class Implementation: InnerElement
	{
		public Implementation ()
		{
			innerPattern =@"(@implementation(?:(?!@implementation|@end).)*@end)";
		}
	}
}

