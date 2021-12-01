using System;

namespace BoltCall.Helper
{
    public static class Wire
    {
        public static string AppDir { get; } = Environment.GetFolderPath
             (Environment.SpecialFolder.LocalApplicationData) + @"\Bolt-Call";
    }
}
