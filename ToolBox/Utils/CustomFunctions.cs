using System;
using System.IO;
using System.Windows;

namespace ToolBox.Utils
{
    public static class CustomFunctions
    {
        internal static void InsertSettingValuesForRensaRevitApiProject()
        {
            try
            {
                var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin\\Rensa.Revit.Api\\appsettings.json";
                var replaceWith = "C:\\TempJsons\\appsettings.json";

                ReplaceFile(replaceWith, filePath);

                DBAppSettingSetAsync();

                MessageBox.Show("Setting values inserted!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void DBAppSettingSetAsync()
        {
            var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin\\Rensa.Revit.Api\\appsettings.Development.json";

            var replaceWith = "C:\\TempJsons\\appsettings.Development.json";

            ReplaceFile(replaceWith, filePath);
        }

        private static void ReplaceFile(string source, string destination)
        {
            File.Copy(source, destination, true);
        }
    }
}

