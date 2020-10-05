using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 20, 22, 16, 18, 28};

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}