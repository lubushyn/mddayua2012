using System.Globalization;
using MdDayCalculator.Servicies;
using MdDayCalculator.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MdDayCalculator.SL.Tests
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
            var stubCalculationService = new Mock<ICalculationService>();
            stubCalculationService.Setup(x => x.Multiplae(firstNumber, secondNumber)).Returns(expectedValue);
            
            var mainPageViewModel = new MainPageViewModel(stubCalculationService.Object)
            {
                FirstNumber = firstNumber.ToString(CultureInfo.InvariantCulture),
                SecondNumber = secondNumber.ToString(CultureInfo.InvariantCulture)
            };
            mainPageViewModel.Calculate();
            Assert.AreEqual(expectedValue.ToString(CultureInfo.InvariantCulture), mainPageViewModel.Result);
        }
    }
}