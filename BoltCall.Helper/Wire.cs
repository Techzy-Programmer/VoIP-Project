using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BoltCall.Helper
{
    public static class Wire
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetDllDirectory(string lpPathName);

        internal static bool HasModulesSet { get; set; } = false;
        internal static string AppDir { get; } = Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData) + @"\Bolt-Call";

        public static bool SetupModules(out string[] Dlls)
        {
            Dlls = null;
            var DLst = new List<string>();
            if (HasModulesSet) return true;

            try
            {
                var MDir = AppDir + "\\Modules";
                Directory.CreateDirectory(MDir);

                foreach (var DLLRes in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                {
                    if (DLLRes.EndsWith(".dll"))
                    {
                        var DllName = DLLRes.Replace("BoltCall.Helper.Binaries.", string.Empty);
                        if (!File.Exists(MDir + $"\\{DllName}"))
                            using (var ORes = Assembly.GetExecutingAssembly()
                                .GetManifestResourceStream(DLLRes))
                            using (var ResFile = new FileStream(MDir + $"\\{DllName}",
                                FileMode.Create, FileAccess.Write)) ORes.CopyTo(ResFile);
                        if (!DllName.Contains("Opus")) DLst.Add(MDir + $"\\{DllName}");
                    }
                }

                Dlls = DLst.ToArray();
                SetDllDirectory(MDir);
                HasModulesSet = true;
                return true;
            }
            catch { }
            return false;
        }
    }
}
