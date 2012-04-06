using System.Collections.Generic;
using NUnit.Framework;

namespace NUnit.Expect.UnitTests
{
    public class ExpectTests : Spec
    {
        [Test]
        public void ToBe_EqualIntegers_IsSuccess()
        {
            Expect(1).ToBe(1);
        }

        [Test]
        public void ToBe_EqualDoubles_IsSuccess()
        {
            Expect(1.0).ToBe(1.0);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ToBe_DifferentDoubles_Fails()
        {
            Expect(1.0).ToBe(1.1);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ToBe_DifferentReferences_Fails()
        {
            var a = new SomeClass();
            var b = new SomeClass();

            Expect(b).ToBe(a);
        }

        [Test]
        public void ToNotBe_DifferentDoubles_IsSuccess()
        {
            Expect(1.1).ToNotBe(1.0);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ToNotBe_EqualDoubles_Fails()
        {
            Expect(1.1).ToNotBe(1.1);
        }

        [Test]
        public void ToBeSame_SameReferences_IsSuccess()
        {
            var a = new SomeClass();
            var b = a;

            Expect(b).ToBeSame(a);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ToBeSame_DifferentReferences_Fails()
        {
            var a = new SomeClass();
            var b = new SomeClass();

            Expect(b).ToBeSame(a);
        }

        [Test]
        public void ToNotBeSame_DifferentReferences_IsSuccess()
        {
            var a = new SomeClass();
            var b = new SomeClass();

            Expect(b).ToNotBeSame(a);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ToNotBeSame_SameReferences_IsSuccess()
        {
            var a = new SomeClass();
            var b = a;

            Expect(b).ToNotBeSame(a);
        }
    }

    public class SomeClass{}
}