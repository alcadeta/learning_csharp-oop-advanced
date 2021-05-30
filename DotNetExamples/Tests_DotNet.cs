using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExamples
{
    [TestClass]
    public class Tests_DotNet
    {
        // List<T> can provide an enumerator because it implements the
        // `IEnumerable` interface. The `GetEnumerator` method returns the said
        // enumerator as an `IEnumerator` object.
        [TestMethod]
        public void Test_IEnumerable()
        {
            var numbers = new List<int> {1, 3, 5, 7, 11};

            // List<T> implements the IEnumerable<T> interface.
            Assert.IsTrue(numbers is IEnumerable<int>);

            // List<T> contains an IEnumerator<T> object, which allows us to
            // iterate over the list.
            var enumerator = numbers.GetEnumerator();
            Assert.IsTrue(enumerator is IEnumerator<int>);

            // Is there any data in the list?
            bool hasData = enumerator.MoveNext();
            Assert.IsTrue(hasData);

            // What's element is the enumerator currently pointing at?
            int index = enumerator.Current;
            Assert.IsTrue(index == numbers[0]);
        }
    }
}