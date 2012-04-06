# NUnit.Expect

Add Expect behavior as to NUnit to use instead of Assert.X

## Why
After using [Jasmine](https://github.com/pivotal/jasmine), I got really fond of the assertion syntax and found it more expressive and at the same time more compact than what exists in NUnit.

## Example

<pre><code>
public class Descriptions : Spec
{
  [Test]
  public void Expect_OnePlusOne_ToBeTwo()
  {
    Expect(1 + 1).ToBe(2); //Will call Assert.That(1 + 1, Is.EqualTo(2));
  }
	
  [Test]
  public void Expect_True_ToNotBeFalse()
  {
    Expect(true).ToNotBe(false); //Will call Assert.That(true, Is.Not.EqualTo(false));
  }
}
</code></pre>