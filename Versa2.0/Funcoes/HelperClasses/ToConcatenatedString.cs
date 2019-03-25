﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versa2._0.Funcoes.HelperClasses
{
    public static class ExtentionMethods
    {
        public static string ToConcatenatedString(
            this List<string> list
            , string separator)
        {
            return String.Join(separator, list);
        }

        public static string ToConcatenatedString(
            this string[] list
            , string separator)
        {
            return String.Join(separator, list);
        }
    }
}