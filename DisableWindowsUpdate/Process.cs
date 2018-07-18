using System;

namespace DisableWindowsUpdate
{
    class Process
    {
        // Creates CMD.exe process and executes given commands 
        public void RunCmd(string command)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C " + command);
        }

        // Disables Windows Update through registry edit and Windows Update Service (wuauserv) through sc
        public void Disable()
        {
            RunCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\Auto Update\" /v AUOptions /t REG_DWORD /d 1 /f");
            RunCmd("net stop wuauserv");
            RunCmd("sc config wuauserv start=disabled");
            Console.WriteLine("Windows Update was successfully disabled!");
            Console.ReadKey();
        }

        // Reverse Disable() 
        public void Enable()
        {
            RunCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\Auto Update\" /v AUOptions /t REG_DWORD /d 3 /f");
            RunCmd("net start wuauserv");
            RunCmd("sc config wuauserv start=auto");
            Console.WriteLine("Windows Update was successfully re-enabled");
            Console.ReadKey();
        }
    }
}
