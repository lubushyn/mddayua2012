using MdDayCalculator.Servicies;

namespace MdDayCalculator.Phone.Tests.ViewModels
{
    public class FakeCalculationService : ICalculationService
    {
        public int Result { set; get; }

        public int Multiplae(int a, int b)
        {
            return Result;
        }
    }
}