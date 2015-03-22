# Fluent Descriptions
A method of describing the expected result of a calculation when writing a unit test.

This library aims to complement Fluent Assertions.  Fluent Assertions is fantastic library which helps you write the Assertions for tests in an easily readable way.

*For Example ...*

```
Given that customer wants their shed painted
When pricing the shed
Then the cost of the paint is added to the price
```

The shed costs £100, the paint costs £23.45

With Fluent Assertions you might have asserted the test as follows:

```c#
this.shedPrice.Should().Be(123.45m);
```
Returning to the test later, it's not immediately obvious how that value is made up - as the calculation gets more complex, the issue is compounded.

This is where Fluent Descriptions steps in:

```c#
this.result.Should().Be(Equal_to.the("basic shed price").of(100) + and_an._("extra cost for the paint").of(23.45m));
```

The vocabulary currently supported is:
```
Equal_to -> the -> [insert word] -> of
Equal_to -> a -> [insert word] -> of

a -> [insert word] -> of
the -> [insert word] -> of
an -> [insert word] -> of
and_a -> [insert word] -> of
and_an -> [insert word] -> of
```

Note: Equal_to also comes in lower case (equal_to) if preferred

The simple set of vocabulary above actually gives a huge range of possibilities - but if you're struggling to describe things with the set above, then please pass a feature request my way.
