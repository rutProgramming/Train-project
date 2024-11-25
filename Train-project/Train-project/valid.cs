using System.Text.RegularExpressions;

namespace Train_project
{
    public class valid
    {
        public bool IsIdValid(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length != 9)
                return false;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                    sum += (2 * value[i]);
                else
                    sum += value[i];
            }
            if (sum > 100)
                sum = sum / 100 + sum % 10 + sum / 10 % 10;
            else
                sum = sum / 10 + sum % 10;
            return sum == 10;

        }
        public bool IsIsraeliPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^0?(([23489]{1}\d{7})|[5]{1}[012345689]\d{7})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        

        public bool IsValidGPSCoordinates(string locationGPSCoordinates)
        {
            string pattern = @"^-?([1-8]?[0-9](\.\d+)?|90(\.0+)?),\s*-?(1[0-7][0-9](\.\d+)?|[0-9]?[0-9](\.\d+)?|180(\.0+)?)$";
            return Regex.IsMatch(locationGPSCoordinates, pattern);
        }
        public bool LastTimeAfterFirstTime(DateTime Firstdate,DateTime LastDate)
        {
            return Firstdate <= LastDate;

        }
    }
}
