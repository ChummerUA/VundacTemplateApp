using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VundacTemplateApp.Extensions
{
    public static class LogExtension
    {
        public static void Log(this object obj, string text = "")
        {
            try
            {
                string log = $"Log:\n" +
                    $"\t{nameof(obj)}\n" +
                    $"\t{obj}";

                if (!string.IsNullOrEmpty(text))
                {
                    log += $"\n\t{text}";
                }

                Debug.WriteLine(log);
            }
            catch { }
        }
    }
}
