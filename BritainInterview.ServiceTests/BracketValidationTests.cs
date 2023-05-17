using BritainInterview.Service;

namespace BritainInterview.ServiceTests
{
    [TestClass]
    public class BracketValidationTests
    {
        private IBracketValidation _bracketValidation = null!;

        [TestInitialize]
        public void Setup()
        {
            _bracketValidation = new BracketValidation();
        }

        [TestMethod]
        public void IsValid_EmptyString_ShouldReturnTrue()
        {
            Assert.IsTrue(_bracketValidation.IsValid(String.Empty));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValid_ShouldThrowArgumentNullException_ForNullString()
        {
            _bracketValidation.IsValid(null);
        }

        [TestMethod]
        public void IsValid_CorrectString_ShouldReturnTrue()
        {
            Assert.IsTrue(_bracketValidation.IsValid("cd(adskf(dskln)[]){ac()}"));
        }

        [TestMethod]
        public void IsValid_IncorrectString1_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid("cd(adskfdskln)[]){ac()}"));
        }

        [TestMethod]
        public void IsValid_IncorrectString2_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid("cd(adskfdskln]){ac()}"));
        }

        [TestMethod]
        public void IsValid_OpenPar_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid("("));
        }

        [TestMethod]
        public void IsValid_ClosePar_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid(")"));
        }

        [TestMethod]
        public void IsValid_CloseBracket_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid("]"));
        }

        [TestMethod]
        public void IsValid_OpenCurly_ShouldReturnFalse()
        {
            Assert.IsFalse(_bracketValidation.IsValid("{"));
        }
    }
}