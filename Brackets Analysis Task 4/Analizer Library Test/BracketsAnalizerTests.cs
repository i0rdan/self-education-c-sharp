using Analizer_Library;
using System.ComponentModel;

namespace Analizer_Library_Test
{
    [TestClass]
    public class BracketsAnalizerTests
    {
        [TestMethod]
        public void Input_IsNull_ShouldThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => BracketsAnalizer.IsValid(null));
        }

        [TestMethod]
        public void Input_WithInvalidBrackets_ShouldThrowInvalidEnumArgumentException()
        {
            Assert.ThrowsException<InvalidEnumArgumentException>(() => BracketsAnalizer.IsValid("a"));
        }

        [TestMethod]
        public void ValidInputs_ShouldReturnTrue()
        {
            string[] validInputs = new string[] {
                "{}{}{}[][][]()()()",
                "{}{{[]}}",
                "{{[(())]}}",
                "{{[]}}",
            };

            foreach (var validInput in validInputs)
            {
                Assert.IsTrue(BracketsAnalizer.IsValid(validInput));
            }
        }

        [TestMethod]
        public void InvalidInputs_ShouldReturnFalse()
        {
            string[] invalidInputs = new string[] {
                "{)",
                "{}[]}}",
                "{{[)]}}",
                "{{",
            };

            foreach (var invalidInput in invalidInputs)
            {
                Assert.IsFalse(BracketsAnalizer.IsValid(invalidInput));
            }
        }
    }
}
