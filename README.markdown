# NUnit.Expect

Add Expect behavior as an extension to NUnit to use instead of Assert.X

## Why
After using [Jasmine](https://github.com/pivotal/jasmine), I got really fond of the assertion syntax and found it more expressive and at the same time more compact than what exists in NUnit.

## Example

<pre><code>[Test]
public void OnePlusOne_ShouldBeTwo()
{
	int sum = 1 + 1;

	Expect(sum).ToBe(2);
}	
</code></pre>