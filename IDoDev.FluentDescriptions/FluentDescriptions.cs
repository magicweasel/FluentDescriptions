namespace FluentDescriptions
{
	public class equal_to
	{
		public static ofValue the(string what)
		{
			return new ofValue();
		}

		public static ofValue a(string what)
		{
			return new ofValue();
		}
	}

	public class Equal_to
	{
		public static ofValue the(string what)
		{
			return new ofValue();
		}

		public static ofValue a(string what)
		{
			return new ofValue();
		}
	}

	public class ofValue
	{
		public T of<T>(T value)
		{
			return value;
		}
	}

	public class a
	{
		public static ofValue _(string what)
		{
			return new ofValue();
		}
	}

	public class an : a
	{
	}

	public class the : a
	{
	}

	public class and_a : a
	{
	}

	public class and_an : a
	{
	}
}
