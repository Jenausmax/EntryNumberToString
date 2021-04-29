using NumberToString.App.Logic;
using NumberToString.Domain.Interfaces;
using NumberToString.View;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting
            ILogicNumberToString logicNumberToString = new LogicNumberToString();
            IView view = new ViewToConsole();

            ILogicProgram logic = new LogicStart(logicNumberToString, view);
            logic.Start();
        }
    }
}
