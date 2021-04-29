

namespace NumberToString.Domain.Interfaces
{
    public interface ILogicNumberToString
    {
        /// <summary>
        /// Method for converting a numeric value to a string record.
        /// </summary>
        /// <param name="money">Number to translate.</param>
        /// <param name="phrase">Response phrases to the user depending on the language.</param>
        /// <param name="culture">true - Russian endings of phrases included. false - Russian endings off.</param>
        /// <returns></returns>
        string NumberToStringPhrases(decimal money, IPhrases phrase, bool culture);
    }
}
