using System;
using System.Linq;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static string a = "国".Length.ToString();
        public static string b = String.Join(", ", "国".ToCharArray().Select(i => ((int)i).ToString()));
        public static string c = "国";
    }
}
