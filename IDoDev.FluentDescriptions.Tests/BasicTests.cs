using FluentAssertions;
using FluentDescriptions;
using NUnit.Framework;

namespace fluent_descriptions_tests
{
	[TestFixture]	
    public class when_describing_calculations
    {
		[Test]
		public void then_integers_sum_correctly()
		{
			123.Should().Be(equal_to.a("value of").of(100) + a._("another value").of(23));
		}

		[Test]
		public void then_doubles_sum_correctly()
		{
			333.33d.Should().Be((equal_to.a("value of").of(110.01d) + a._("another value").of(1.1d)) * the._("multiplier").of(3d));
		}

		[Test]
		public void then_integers_and_doubles_sum_correctly()
		{
			500.99d.Should().Be(equal_to.a("value of").of(500) + a._("another value").of(0.99d));
		}

		[Test]
		public void then_floats_sum_correctly()
		{
			444.44f.Should().Be(Equal_to.the("value of").of(444.40f) + an._("extra value of").of(0.04f));
		}

		[Test]
		public void then_decimals_sum_correctly()
		{
			33.55m.Should().Be(Equal_to.the("value of").of(33.5m) + and_a._("value of").of(0.05m));
		}

		[Test]
		public void then_decimals_and_integers_sum_correctly()
		{
			12.34m.Should().Be(Equal_to.the("value of").of(12) + and_an._("extra value of").of(0.34m));
		}
    }
}
