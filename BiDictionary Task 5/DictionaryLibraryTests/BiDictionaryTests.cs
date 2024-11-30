using Dictionary_Library;

namespace DictionaryLibraryTests
{
    [TestClass]
    public class BiDictionaryTests
    {
        [TestMethod]
        public void ShouldInverseItemsCorrectly()
        {
            var key = "test_key";
            var value = "test_value";
            var dict = new BiDictionary<string, string>()
            {
                [key] = value,
            };

            Assert.AreEqual(value, dict[key]);
            Assert.AreEqual(key, dict.Inverse[value]);
        }

        [TestMethod]
        public void ShouldThrowErrorForItems_WithNullValues()
        {
            var key = "test_key";
            var dict = new BiDictionary<string, string?>()
            {
                [key] = null,
            };

            Assert.IsNull(dict[key]);
            Assert.AreEqual(0, dict.Inverse.Count);
        }

        [TestMethod]
        public void ShouldSkipDuplicateItems()
        {
            var firstKey = "test_key1";
            var secondKey = "test_key2";
            var value = "test_value";
            var dict = new BiDictionary<string, string?>()
            {
                [firstKey] = value,
                [secondKey] = value,
            };

            Assert.AreEqual(value, dict[firstKey]);
            Assert.AreEqual(value, dict[secondKey]);
            Assert.AreEqual(firstKey, dict.Inverse[value]);
            Assert.AreEqual(1, dict.Inverse.Count);
        }
    }
}
