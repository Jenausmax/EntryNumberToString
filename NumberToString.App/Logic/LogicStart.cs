using System;
using NumberToString.App.Infrastructure;
using NumberToString.Domain.Interfaces;

namespace NumberToString.App.Logic
{
    public class LogicStart : ILogicProgram
    {
        private IView _view;
        private ILogicNumberToString _logicNumberToString;
        private IPhrases _phrases;

        public LogicStart(ILogicNumberToString logicNumber, IView view)
        {
            _view = view;
            _logicNumberToString = logicNumber;
        }
        public void Start()
        {
            while (true)
            {
                _view.PrintText("Выберите язык(Choose language): \n1 - RUS\n2 - ENG");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        _phrases = new RusPhrases();
                        LogicWork(_phrases, true);
                        break;


                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        _phrases = new EngPhrases();
                        LogicWork(_phrases, false);
                        break;


                    default:
                        _view.PrintText("Нажмите 1 или 2 (Press 1 or 2)");
                        _view.InputUser();
                        break;
                }
            }
        }

        private void LogicWork(IPhrases phrase, bool culture)
        {
            _view.PrintText(phrase.InputUser);
            decimal inputNumber = 0;
            if (decimal.TryParse(_view.InputUser(), out inputNumber))
            {
                if (inputNumber > 0 && inputNumber < 2000000000m)
                {
                    _view.PrintText(_logicNumberToString.NumberToStringPhrases(inputNumber, _phrases, culture));
                    _view.InputUser();
                    return;
                }

                _view.PrintText(phrase.ExceededValueError);
                _view.InputUser();
            }
            else
            {
                _view.PrintText(phrase.InputError);
                _view.InputUser();
            }
        }
    }
}
