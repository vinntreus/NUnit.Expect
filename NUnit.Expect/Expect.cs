using NUnit.Framework;

namespace NUnit.Expect
{
    /// <summary></summary>
    public class Expect<T>
    {
        private readonly T actual;

        internal Expect(T actual)
        {
            this.actual = actual;
        }

        /// <summary>Compares with EqualTo</summary>
        /// <param name="result"></param>
        public void ToBe(T result)
        {
            Assert.That(actual, Is.EqualTo(result));
        }

        /// <summary>Compares with Not.EqualTo</summary>
        /// <param name="result"></param>
        public void ToNotBe(T result)
        {
            Assert.That(actual, Is.Not.EqualTo(result));
        }

        /// <summary>Compares with SameAs</summary>
        /// <param name="result"></param>
        public void ToBeSame(T result)
        {
            Assert.That(actual, Is.SameAs(result));
        }

        /// <summary>Compares with Not.SameAs</summary>
        /// <param name="result"></param>
        public void ToNotBeSame(T result)
        {
            Assert.That(actual, Is.Not.SameAs(result));
        }
    }
}