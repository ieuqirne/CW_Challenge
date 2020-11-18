using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new string(arr);
            return s;

            throw new NotImplementedException();
        }
    }
}
