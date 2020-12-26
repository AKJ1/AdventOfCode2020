using System;
using System.Globalization;
using System.Linq;

namespace d.PassportProcessing
{
    class PassportProcessing
    {
        private static string[] requiredFields = new[] {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
        private static string[] validEcl = new[] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
        
        static void Main(string[] args)
        {
            string[] parsedPassports = Input.Data.Split("\r\n\r\n")
                                            .Select( s=> s.Replace("\r\n", " "))
                                            .ToArray();

            int validCount = CalcStageOne(parsedPassports);
            Console.WriteLine(validCount);
            
            int validCountValidated = CalcStageTwo(parsedPassports);
            Console.WriteLine(validCountValidated);
        }

        public static int CalcStageOne(string[] parsedPassports)
        {
            int validCount = 0;
            foreach (var pp in parsedPassports)
            {
                validCount += ValidateFieldPresence(pp) ? 1 : 0;
            }
            return validCount;
        }

        private static bool ValidateFieldPresence(string pp)
        {
            for (int i = 0; i < requiredFields.Length; i++)
            {
                if (!pp.Contains(requiredFields[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //There's a case where this shit breaks. Prints 117 when answer is 116
        public static bool ValidatePassport(string pp)
        {
            if (!ValidateFieldPresence(pp)) return false;
            string[] fields = pp.Split(" ");
            bool isValid = true;
            foreach (var field in fields)
            {
                string[] pair = field.Split(":");
                switch (pair[0])
                {
                    case "byr":
                        int byrVal = 0;
                        bool byrValid = int.TryParse(pair[1], out byrVal);
                        isValid &= byrValid && byrVal >= 1920 && byrVal <= 2020;
                        break;
                    case "iyr":
                        int iyrVal = 0;
                        bool iyrValid = int.TryParse(pair[1], out iyrVal);
                        isValid &= iyrValid && iyrVal >= 2010 && iyrVal <= 2020;
                        break;
                    case "eyr":
                        int eyrVal = 0;
                        bool eyrValid = int.TryParse(pair[1], out eyrVal);
                        isValid &= eyrValid && eyrVal >= 2020 && eyrVal <= 2030;
                        break;
                    case "hgt":
                        string clean = pair[1].Replace("cm", "").Replace("in", "");
                        bool validHeight = pair[1].Contains("cm") || pair[1].Contains("in");
                        (int lo, int hi) = pair[1].Contains("cm") ? (150, 193) : (59, 76);
                        int heightValue = 0;
                        bool validValue = int.TryParse(clean, out heightValue);
                        validValue &= heightValue >= lo && heightValue <= hi;
                        isValid &= validHeight && validValue;
                        break;
                    case "hcl":
                        int hclVal = 0;
                        bool hclValidHex = int.TryParse(pair[1].Substring(1), System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture,  out hclVal);
                        bool hclValidColor = pair[1][0].Equals('#') && pair[1].Length == 7; 
                        isValid &= hclValidHex && hclValidColor;
                        break;
                    case "ecl":
                        isValid &= validEcl.Contains(pair[1]);
                        break;
                    case "pid":
                        int pidVal = 0;
                        bool pidValid = int.TryParse(pair[1], out pidVal);
                        isValid &= pair[1].Length == 9 && pidValid;
                        break;
                }
            }
            return isValid;
        }

        public static int CalcStageTwo(string[] parsedPassports)
        {
            int validCount = 0;
            foreach (var pp in parsedPassports)
            {
                validCount += ValidatePassport(pp) ? 1 : 0;
            }
            return validCount;
        }
    }
}