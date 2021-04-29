using NumberToString.Domain.Interfaces;

namespace NumberToString.App.Infrastructure
{
    internal class RusPhrases : IPhrases
    {
        public string[] Units { get; set; } =
        {
            "", " од", " дв", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять", " десять",
            " одиннадцать", " двенадцать", " тринадцать", " четырнадцать", " пятнадцать", " шестнадцать", " семнадцать",
            " восемнадцать", " девятнадцать"
        };

        public string[] Ten { get; set; } =
        {
            "", "", " двадцать", " тридцать", " сорок", " пятьдесят", " шестьдесят", " семьдесят", " восемьдесят",
            " девяносто"
        };

        public string[] Hundreds { get; set; } =
        {
            "", " сто", " двести", " триста", " четыреста", " пятьсот", " шестьсот", " семьсот", " восемьсот",
            " девятьсот"
        };

        public string[] Millions { get; set; } =
            {"", "", " тысяч", " миллион", " миллиард", " триллион", " квадрилион", " квинтилион"};

        public string[] Сurrency { get; set; } = { "рубль", "рубля", "рублей", "копейка", "копейки", "копеек" };
        public string NullNumber { get; set; } = "ноль";
        public string InputUser { get; set; } = "Введите сумму до 2 миллиардов рублей: ";
        public string ExceededValueError { get; set; } = "Число должно быть больше нуля или меньше 2 миллиардов";
        public string InputError { get; set; } = "Введите число! Было введено не число";
    }
}
