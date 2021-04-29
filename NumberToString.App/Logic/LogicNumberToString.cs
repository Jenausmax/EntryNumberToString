using NumberToString.Domain.Interfaces;

namespace NumberToString.App.Logic
{
    public class LogicNumberToString : ILogicNumberToString
    {
        public string NumberToStringPhrases(decimal money, IPhrases phrase, bool culture)
        {
            return CurPhrase(money, phrase, culture);
        }


        private string NumPhrase(IPhrases phrases, ulong value, bool isMale, bool toUpper, bool culture)
        {
            if (value == 0UL) return phrases.NullNumber;

            string phrase = "";

            for (byte th = 1; value > 0; th++)
            {
                ushort gr = (ushort)(value % 1000);
                value = (value - gr) / 1000;
                if (gr > 0)
                {
                    byte d3 = (byte)((gr - gr % 100) / 100);
                    byte d1 = (byte)(gr % 10);
                    byte d2 = (byte)((gr - d3 * 100 - d1) / 10);
                    if (d2 == 1) d1 += (byte)10;
                    bool ismale = (th > 2) || ((th == 1) && isMale);
                    if (culture)
                    {
                        phrase = phrases.Hundreds[d3] + phrases.Ten[d2] + phrases.Units[d1] + EndDek1(d1, ismale) + phrases.Millions[th] + EndTh(th, d1) + phrase;
                    }
                    else
                    {
                        phrase = phrases.Hundreds[d3] + phrases.Ten[d2] + phrases.Units[d1] + phrases.Millions[th] + phrase;
                    }
                    
                };
            };

            if (toUpper)
            {
                phrase = phrase.Substring(1, 1).ToUpper() + phrase.Substring(2);
            }

            return phrase;
        }


        private string CurPhrase(decimal money, IPhrases phrases, bool culture)
        {
            money = decimal.Round(money, 2);
            decimal decIntPart = decimal.Truncate(money);
            ulong intPart = decimal.ToUInt64(decIntPart);
            string str = NumPhrase(phrases, intPart, true, true, culture) + " ";
            byte endPart = (byte)(intPart % 100UL);
            if (endPart > 19) endPart = (byte)(endPart % 10);
            switch (endPart)
            {
                case 1: str += phrases.Сurrency[0]; break;
                case 2:
                case 3:
                case 4: str += phrases.Сurrency[1]; break;
                default: str += phrases.Сurrency[2]; break;
            }
            byte fracPart = decimal.ToByte((money - decIntPart) * 100M);
            str += " " + NumPhrase(phrases, fracPart, true, false, culture) + " ";
            if (fracPart > 19) fracPart = (byte)(fracPart % 10);
            switch (fracPart)
            {
                case 1: str += phrases.Сurrency[3]; break;
                case 2:
                case 3:
                case 4: str += phrases.Сurrency[4]; break;
                default: str += phrases.Сurrency[5]; break;
            };
            return str;
        }

        private string EndTh(byte thNum, byte dek)
        {
            bool in234 = ((dek >= 2) && (dek <= 4));
            bool more4 = ((dek > 4) || (dek == 0));
            if (((thNum > 2) && in234) || ((thNum == 2) && (dek == 1))) return "а";
            else if ((thNum > 2) && more4) return "ов";
            else if ((thNum == 2) && in234) return "и";
            else return "";
        }


        private string EndDek1(byte dek, bool isMale)
        {
            if ((dek > 2) || (dek == 0)) return "";
            else if (dek == 1)
            {
                if (isMale) return "ин";
                else return "на";
            }
            else
            {
                if (isMale) return "а";
                else return "е";
            }
        }
    }
}
