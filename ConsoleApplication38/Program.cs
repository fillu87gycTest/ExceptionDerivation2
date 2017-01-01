/*
 * catch ExptA
 * catch ExptB
 * System.Exception: 種類 'System.Exception' の例外がスローされました。
 * 場所 Program.Main() 場所 D:\Program\Cs\ConsoleApplication38\ConsoleApplication38\Program.cs:行 15
 * 続行するには何かキーを押してください . . .
*/

using System;

class Program
{
	static void Main()
	{
		for (int i = 0; i < 3; i++)
		{
			try
			{
				switch (i)
				{
					case 0:	 throw new ExcptA("catch ExptA");
					case 1:  throw new ExcptB("catch ExptB");
					default: throw new Exception();
				}
			}
			//ここから下のcatch文の順番は順不同ではない
			catch (ExcptB exc)
			{
				Console.WriteLine(exc);
			}
			catch (ExcptA exc)
			{
				Console.WriteLine(exc);
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc);
			}
		}
	}
}