
namespace NumberToString.Domain.Interfaces
{
    public interface IView
    {
        /// <summary>
        /// Text printing method.
        /// </summary>
        /// <param name="message">Print message.</param>
        void PrintText(string message);
        /// <summary>
        /// Method to wait for user response.
        /// </summary>
        /// <returns>Response string</returns>
        string InputUser();

    }
}
