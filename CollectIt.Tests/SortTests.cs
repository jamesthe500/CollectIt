using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class SortedTests
    {
        [TestMethod]
        public void Can_Use_Sorted_List()
        {
            // SortedList is optimized to use lower memory than SortedDictionary
            // Sorted Dictioary is best if you're going to be looking up things by key value often
            // SortedList for looping through things a lot
            var list = new SortedList<int, string>();

            list.Add(3, "three");
            list.Add(1, "one");
            list.Add(2, "two");

            Assert.AreEqual(0, list.IndexOfKey(1));
            Assert.AreEqual(1, list.IndexOfValue("two"));
        }

        [TestMethod]
        public void Can_Use_Sorted_Set()
        {
            // much like a hash set, only allows unique values, just keeps them in order
            var set = new SortedSet<int>();

            set.Add(3);
            set.Add(1);
            set.Add(2);

            var enumerator = set.GetEnumerator();
            enumerator.MoveNext();
            Assert.AreEqual(enumerator.Current, 1);
        }
    }
}
