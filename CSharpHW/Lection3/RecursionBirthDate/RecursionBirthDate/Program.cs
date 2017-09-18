using System;
using System.Globalization;

namespace RecursionBirthDate
{
    class RecursionBirthDate
    {
        private const string Capricorn = "Capricorn";
        private const string Aquarius = "Aquarius";
        private const string Pisces = "Pisces";
        private const string Aries = "Aries";
        private const string Taurus = "Taurus";
        private const string Gemini = "Gemini";
        private const string Cancer = "Cancer";
        private const string Leo = "Leo";
        private const string Virgo = "Virgo";
        private const string Libra = "Libra";
        private const string Scorpio = "Scorpio";
        private const string Sagittarius = "Sagittarius";
        private const string Format = "dd/MM/yyyy";

        static void Main(string[] args)
        {
            var dateOfBirth = CheckBirthDate();
            var age = DateTime.Now.Year - dateOfBirth.Year;
            Output(FindOutZodiacSign(dateOfBirth), age);
            Console.ReadKey();
        }

        private static DateTime CheckBirthDate()
        {
            DateTime dt;
            Console.WriteLine("Enter your date of birth in " + Format + " format: ");
            string birthDate = Console.ReadLine();

            if (DateTime.TryParseExact(birthDate, Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                return dt;
            }
            return CheckBirthDate();
        }

        private static string FindOutZodiacSign(DateTime dt)
        {
            int month = dt.Month;
            int day = dt.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return Capricorn;
                    return Aquarius;

                case 2:
                    if (day <= 18)
                        return Aquarius;
                    return Pisces;
                case 3:
                    if (day <= 20)
                        return Pisces;
                    return Aries;
                case 4:
                    if (day <= 19)
                        return Aries;
                    return Taurus;
                case 5:
                    if (day <= 20)
                        return Taurus;
                    return Gemini;
                case 6:
                    if (day <= 20)
                        return Gemini;
                    return Cancer;
                case 7:
                    if (day <= 22)
                        return Cancer;
                    return Leo;
                case 8:
                    if (day <= 22)
                        return Leo;
                    return Virgo;
                case 9:
                    if (day <= 22)
                        return Virgo;
                    return Libra;
                case 10:
                    if (day <= 22)
                        return Libra;
                    return Scorpio;
                case 11:
                    if (day <= 21)
                        return Scorpio;
                    return Sagittarius;
                case 12:
                    if (day <= 21)
                        return Sagittarius;
                    return Capricorn;
            }
            return "";
        }

        private static void Output(string zodiac, int age)
        {
            Console.WriteLine("Your zodiac sign is "+ zodiac);
            Console.WriteLine("Your age is "+ age);
        }
    }
}