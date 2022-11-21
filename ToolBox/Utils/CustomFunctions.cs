using System;
using System.IO;
using System.Windows;

namespace ToolBox.Utils
{
    public static partial class CustomFunctions
    {
        internal static void InsertSettingValuesForRensaRevitApiProject()
        {
            try
            {
                var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin\\Rensa.Revit.Api\\appsettings.json";
                var replaceWith = "C:\\TempJsons\\appsettings.json";

                ReplaceFile(replaceWith, filePath);

                SetDBAppSetting();
                SetAppSettingForOldProject();
                SetDBAppSettingForOldProject();

                MessageBox.Show("Setting values inserted!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

