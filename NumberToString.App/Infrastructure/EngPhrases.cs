using NumberToString.Domain.Interfaces;

namespace NumberToString.App.Infrastructure
{
    internal class EngPhrases : IPhrases
    {
        public string NullNumber { get; set; } = "null";

        public string[] Units { get; set; } = {"", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten",
            " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen",
            " eighteen", " nineteen" };

        public string[] Ten { get; set; } = {"", "", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty",
            " ninety" };

        public string[] Hundreds { get; set; } = { "", " one hundred", " two hundred", " three hundred", " four hundred", " five hundred", " six hundred", " seven hundred", " eight hundred",
            " nine hundred"};

        public string[] Millions { get; set; } = { "", "", " thousand", " million", " billion", " trillion", " quadrillion", " quintillion" };
        public string[] Сurrency { get; set; } = { "dollar", "dollar", "dollars", "cent", "cent", "cents" };
        public string InputUser { get; set; } = "Enter an amount up to $ 2 billion: ";
        public string ExceededValueError { get; set; } = "The number must be greater than zero or less than 2 billion.";
        public string InputError { get; set; } = "Please enter a number! No number was entered";
    }
}
