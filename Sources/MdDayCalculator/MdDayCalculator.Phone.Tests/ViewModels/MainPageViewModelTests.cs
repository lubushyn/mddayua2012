using System.Globalization;
using MdDayCalculator.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MdDayCalculator.Phone.Tests.ViewModels
{
    [TestClass]
    public class MainPageViewModelTests
    {
        [TestMethod]
        public void Calculate_PassValidNumbers_ValidResult()
        {
            const int firstNumber = 10;
            const int secondNumber = 5;
            const int expectedValue = firstNumber * secondNumber;

            var fakeCalculationService = new FakeCalculationService {Result = expectedValue};
            var mainPageViewModel = new MainPageViewModel(fakeCalculationService)
                {
                    FirstNumber = firstNumber.ToString(CultureInfo.InvariantCulture),
                    SecondNumber = secondNumber.ToString(CultureInfo.InvariantCulture)
                };
            mainPageViewModel.Calculate();
            Assert.AreEqual(expectedValue.ToString(), mainPageViewModel.Result);
        }
    }
}
