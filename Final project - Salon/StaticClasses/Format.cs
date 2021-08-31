using System;

namespace Final_project___Salon
{
    /// <summary>
    /// For use string format settings
    /// </summary>
    public static class Format
    {
        /// <summary>
        /// Format double number to string with 2 places after dot
        /// </summary>
        /// <param name="numb"> number for formating</param>
        /// <returns></returns>
        public static string FormatDuobleOneDecPlaces(double numb)
        {
           string newNumb = String.Format("{0:0.00}", numb);
            return newNumb;
        }
        /// <summary>
        /// Format double number to string with 1 places after dot
        /// </summary>
        /// <param name="numb"> number for formating</param>
        /// <returns></returns>
        public static string FormatDuobleTwoDecPlaces(double numb)
        {
            string newNumb = String.Format("{0:0.0}", numb);
            return newNumb;
        }
        /// <summary>
        /// Format double number to string with 3 places after dot
        /// </summary>
        /// <param name="numb"> number for formating</param>
        /// <returns></returns>
        public static string FormatDuobleThreeDecPlaces(double numb)
        {
            string newNumb = String.Format("{0:0.000}", numb);
            return newNumb;
        }
        /// <summary>
        /// Format double number to string with 4 places after dot
        /// </summary>
        /// <param name="numb"> number for formating</param>
        /// <returns></returns>
        public static string FormatDuobleFourDecPlaces(double numb)
        {
            string newNumb = String.Format("{0:0.0000}", numb);
            return newNumb;
        }

    }
}
