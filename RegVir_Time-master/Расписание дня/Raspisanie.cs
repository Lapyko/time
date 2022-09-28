using System;
using System.Text.RegularExpressions;

namespace RegVir
{
    internal class Raspisanie
    {
        public void raspisanie()
        {
            string s = "Утром: подъем 07:00, завтрак 07:30, тренировка 09:00, игра 10:00. " +
                    "Вечером: восстонавление 18:00, прогулка 18:54, подготовка ко сну 25:03, сон 00:00.";
            Regex regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
        }
    }
}
