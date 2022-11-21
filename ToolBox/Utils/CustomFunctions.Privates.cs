using System.IO;

namespace ToolBox.Utils
{
    public static partial class CustomFunctions
    {
        private static void SetDBAppSetting()
        {
            var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin\\Rensa.Revit.Api\\appsettings.Development.json";

            var replaceWith = "C:\\TempJsons\\appsettings.Development.json";

            ReplaceFile(replaceWith, filePath);
        }
        
        private static void SetAppSettingForOldProject()
        {
            var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin.Old\\Rensa.Revit.Api\\appsettings.json";
            var replaceWith = "C:\\TempJsons\\appsettings.json";

            ReplaceFile(replaceWith, filePath);
        }
        
        private static void SetDBAppSettingForOldProject()
        {
            var filePath = "C:\\Users\\Administrator\\source\\repos\\RevitPlugin.Old\\Rensa.Revit.Api\\appsettings.Development.json";

            var replaceWith = "C:\\TempJsons\\appsettings.Development.json";

            ReplaceFile(replaceWith, filePath);
        }

        private static void ReplaceFile(string source, string destination)
        {
            File.Copy(source, destination, true);
        }
    }
}

