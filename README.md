# Fluent Descriptions
A method of describing the expected result of a calculation when writing a unit test.

This library aims to complement Fluent Assertions.  Fluent Assertions is fantastic library which helps you write the Assertions for tests in an easily readable way.

*For Example ...*

Given that customer wants their shed painted
When pricing the shed
Then the price of the paint is added

The shed costs £100, the paint costs £23.45

With Fluent Assertions you might have asserted the test as follows:

```c#
this.shedPrice.Should().Be(123.45m);
```
Returned to the test later, it's not immediately obvious how that value is made up - as the calculation gets more complex, the issue is componded.

This is where Fluent Descriptions steps in:

```c#
this.result.Should().Be(Equal_to.the("basic shed price").of(100) + and_an._("extra cost for the paint").of(23.45m));
```

