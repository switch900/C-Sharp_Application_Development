using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace COMP2614Assign05
{
    /// <summary>
    /// Class which contains only 1 method which takes the input from the 3 text boxes and confirms that they are a good date.  
    /// Returning a true or false answer.
    /// </summary>
    class DateValidator
    {
        public const int OLD_YEAR = 1900;//oldest year that is valid

        /// <summary>
        /// Method to validate date
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <param name="Day"></param>
        /// <returns>Is valid date as a bool</returns>
        public static bool Validate(string Year, string Month, string Day)
        {
            int intYear;
            bool isNumericYear = Int32.TryParse(Year, out intYear);
            int intMonth;
            bool isNumericMonth = Int32.TryParse(Month, out intMonth);
            int intDay;
            bool isNumericDay =Int32.TryParse(Day, out intDay);
            DateTime date = new DateTime();
            bool isValid = false;

            try
            {
                if (intYear >= OLD_YEAR)
                {
                    date = new DateTime(intYear, intMonth, intDay);
                    isValid = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                isValid = false;
            }
            catch (ArgumentException)
            {
                isValid = false;
            }
            string stringDate = String.Format("{0:MM/d/yyyy}", date);
            DateTime dateTime;
            if (DateTime.TryParseExact(stringDate, "MM/ddd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out dateTime) == true)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}