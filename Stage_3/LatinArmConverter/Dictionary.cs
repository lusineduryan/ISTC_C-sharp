using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinArmConverter
{
    public static class StringExtensions
    {
        public static string Grammar(string twoChar)
        {
            string armtext = "";
            armtext = twoChar.Replace("ev", "և");
            armtext = twoChar.Replace("EV", "և");
            armtext = twoChar.Replace("Ev", "և");
            armtext = twoChar.Replace("ch", "չ");
            armtext = twoChar.Replace("CH", "Չ");
            armtext = twoChar.Replace("Ch", "Չ");
            armtext = twoChar.Replace("sh", "շ");
            armtext = twoChar.Replace("SH", "Շ");
            armtext = twoChar.Replace("Sh", "Շ");
            armtext = twoChar.Replace("kh", "խ");
            armtext = twoChar.Replace("KH", "Խ");
            armtext = twoChar.Replace("Kh", "Խ");
            armtext = twoChar.Replace("gh", "ղ");
            armtext = twoChar.Replace("GH", "Ղ");
            armtext = twoChar.Replace("Gh", "Ղ");
            armtext = twoChar.Replace("dz", "ձ");
            armtext = twoChar.Replace("DZ", "Ձ");
            armtext = twoChar.Replace("Dz", "Ձ");
            armtext = twoChar.Replace("ts", "ծ");
            armtext = twoChar.Replace("TS", "Ծ");
            armtext = twoChar.Replace("Ts", "Ծ");
            armtext = twoChar.Replace("ye", "ե");
            armtext = twoChar.Replace("YE", "Ե");
            armtext = twoChar.Replace("Ye", "Ե");
            armtext = twoChar.Replace("vo", "ո");
            armtext = twoChar.Replace("VO", "Ո");
            armtext = twoChar.Replace("Vo", "Ո");
            return armtext;
        }

        public static string LatinToArm(this string latin)
        {
            string arm = "";
            latin = Grammar(latin);
            Dictionary<char, string> LatinArm = new Dictionary<char, string>();
            LatinArm['a'] = "ա";
            LatinArm['A'] = "Ա";
            LatinArm['b'] = "բ";
            LatinArm['B'] = "Բ";
            LatinArm['c'] = "ց";
            LatinArm['C'] = "Ց";
            LatinArm['d'] = "դ";
            LatinArm['D'] = "Դ";
            LatinArm['e'] = "է";
            LatinArm['E'] = "Է";
            LatinArm['f'] = "ֆ";
            LatinArm['F'] = "Ֆ";
            LatinArm['g'] = "գ";
            LatinArm['G'] = "Գ"; 
            LatinArm['h'] = "հ";
            LatinArm['H'] = "Հ";
            LatinArm['i'] = "ի";
            LatinArm['I'] = "Ի";
            LatinArm['j'] = "ջ";
            LatinArm['J'] = "Ջ";
            LatinArm['k'] = "կ";
            LatinArm['K'] = "Կ";
            LatinArm['l'] = "լ";
            LatinArm['L'] = "Լ";
            LatinArm['m'] = "մ";
            LatinArm['M'] = "Մ";
            LatinArm['n'] = "ն";
            LatinArm['N'] = "Ն";
            LatinArm['o'] = "օ";
            LatinArm['O'] = "Օ";
            LatinArm['p'] = "պ";
            LatinArm['P'] = "Պ";
            LatinArm['q'] = "ք";
            LatinArm['Q'] = "Ք";
            LatinArm['r'] = "ռ";
            LatinArm['R'] = "Ռ";
            LatinArm['s'] = "ս";
            LatinArm['S'] = "Ս";
            LatinArm['t'] = "տ";
            LatinArm['T'] = "Տ";
            LatinArm['u'] = "ու";
            LatinArm['U'] = "ՈՒ";
            LatinArm['v'] = "վ";
            LatinArm['V'] = "Վ";
            LatinArm['w'] = "վ";
            LatinArm['W'] = "Վ";
            LatinArm['x'] = "խ";
            LatinArm['X'] = "Խ";
            LatinArm['y'] = "յ";
            LatinArm['Y'] = "Յ";
            LatinArm['z'] = "զ";
            LatinArm['Z'] = "Զ";
            
            foreach (var item in latin)
            {
                try
                {
                    arm += LatinArm[item];
                }
                catch (Exception e )
                {
                    Console.WriteLine("Please enter a text!");
                }
            }

            return arm;
        }
    }
}
