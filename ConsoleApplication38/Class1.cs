using System;
class ExcptA : Exception
{
	public ExcptA() : base() { }
	public ExcptA(string message) : base(message) { }
	public override string ToString()
	{
		return Message;
	}
}
class ExcptB : ExcptA
{
	public ExcptB() : base() { }
	public ExcptB(string message) : base(message) { }
	public override string ToString()
	{
		return Message;
	}
}