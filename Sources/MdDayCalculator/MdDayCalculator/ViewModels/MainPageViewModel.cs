using System.Linq;
using MdDayCalculator.Servicies;

namespace MdDayCalculator.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private readonly ICalculationService _calculationService;
        private string _firstNumber;
        private string _secondNumber;
        private string _validationMessage;
        private string _result = "?";

        public string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                if (_firstNumber != value)
                {
                    _firstNumber = value;
                    RaisePropertyChangedEvent("FirstNumber");
                }
            }
        }

        public string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                if (_secondNumber != value)
                {
                    _secondNumber = value;
                    RaisePropertyChangedEvent("SecondNumber");
                }
            }
        }

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    RaisePropertyChangedEvent("Result");
                }
            }
        }

        public string ValidationMessage
        {
            get
            {
                return _validationMessage;
            }
            set
            {
                if (_validationMessage != value)
                {
                    _validationMessage = value;
                    RaisePropertyChangedEvent("ValidationMessage");
                }
            }
        }

        public MainPageViewModel()
        {
            _calculationService = new CalculationService();
        }

        public MainPageViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public void Calculate()
        {
            if (!ValidateInput())
            {
                return;
            }

            int firstNumber = int.Parse(FirstNumber);
            int secondNumber = int.Parse(SecondNumber);
            Result = _calculationService.Multiplae(firstNumber, secondNumber).ToString();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(FirstNumber) || string.IsNullOrWhiteSpace(SecondNumber))
            {
                ValidationMessage = "Please enter two numbers.";
                return false;
            }

            if (FirstNumber.Any(character => !char.IsDigit(character)))
            {
                ValidationMessage = "Please enter a valid first number.";
                return false;
            }

            if (SecondNumber.Any(character => !char.IsDigit(character)))
            {
                ValidationMessage = "Please enter a valid second number.";
                return false;
            }

            ValidationMessage = string.Empty;
            return true;
        }

        
    }
}
