// ReSharper disable CheckNamespace
namespace NUnit.Framework
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Inherit this class to enable Expects
    /// </summary>
    [TestFixture]
    public abstract class Spec
    {
        /// <summary>Accepts subject to test</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="actual">Subject to test</param>
        public static Expect<T> Expect<T>(T actual)
        {
            return new Expect<T>(actual);
        }
    }
}