using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MdDayCalculator.Servicies
{
    public class CalculationService : ICalculationService
    {

        public int Multiplae(int a, int b)
        {
            return a * b;
        }
    }
}
