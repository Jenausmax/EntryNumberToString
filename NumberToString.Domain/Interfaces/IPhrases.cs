
namespace NumberToString.Domain.Interfaces
{
    public interface IPhrases
    {
        /// <summary>
        /// Phrase zero.
        /// </summary>
        string NullNumber { get; set; }
        /// <summary>
        /// Array of phrases from 1 to 10.
        /// </summary>
        string[] Units { get; set; }
        /// <summary>
        /// Array of phrases "tens".
        /// </summary>
        string[] Ten { get; set; }
        /// <summary>
        /// Array of phrases "hundreds".
        /// </summary>
        string[] Hundreds { get; set; }
        /// <summary>
        /// Array of phrases "billions".
        /// </summary>
        string[] Millions { get; set; }
        /// <summary>
        /// Array of phrases "currency".
        /// </summary>
        string[] Сurrency { get; set; }
        /// <summary>
        /// User text input phrase.
        /// </summary>
        string InputUser { get; set; }
        /// <summary>
        /// The phrase "Error exceeding the specified number".
        /// </summary>
        string ExceededValueError { get; set; }
        /// <summary>
        /// The phrase "Input error".
        /// </summary>
        string InputError { get; set; }
    }
}
