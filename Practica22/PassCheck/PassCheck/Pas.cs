using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassCheck
{
    public class Pas
    {
        public bool Check(string pass)
        {
            if (pass.Length < 6)
                return false;
            int numcntl=0, letcnt=0 ;
            bool R=false, r=false,ss=false,num=false;
            foreach (char s in pass)
            {
                if(char.IsDigit(s))
                    numcntl++;
                if(char.IsLetter(s))
                    letcnt++;
                if (char.IsUpper(s))
                    R = true;
                if (char.IsLower(s))
                    r = true;
                ss = s == '!'|| s == '#'|| s == '@'|| s == '%'|| s == '$'||s == '^';
                num = numcntl < letcnt;
            }
            if (ss && num && R && r)
                return true;
            else
                return false;
        }
    }
}
