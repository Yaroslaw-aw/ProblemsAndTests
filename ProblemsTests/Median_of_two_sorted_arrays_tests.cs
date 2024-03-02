using Problems;

namespace ProblemsTests
{
    [TestClass]
    public class Median_of_two_sorted_arrays_tests
    {
        [TestMethod]
        public void Test1FindMedianSortedArrays()
        {
            Median_of_two_sorted_arrays medianCalculator = new Median_of_two_sorted_arrays();

            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 4 };

            double median = medianCalculator.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2.5, median);
        }


        [TestMethod]
        public void Test2FindMedianSortedArrays()
        {
            Median_of_two_sorted_arrays medianCalculator = new Median_of_two_sorted_arrays();

            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            double median = medianCalculator.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, median);
        }

        [TestMethod]
        public void Test3FindMedianSortedArrays()
        {
            Median_of_two_sorted_arrays medianCalculator = new Median_of_two_sorted_arrays();

            int[] nums1 = { 2 };
            int[] nums2 = {  };

            double median = medianCalculator.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(2, median);
        }
    }
}