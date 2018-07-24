using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace testPSAPI2
{
    class Program
    {
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }

        [Flags]
        public enum FilterFlags : uint
        {
            LIST_MODULES_32BIT = 0x01,
            LIST_MODULES_64BIT = 0x02,
            LIST_MODULES_ALL = 0x03,
            LIST_MODULES_DEFAULT = 0x0
        }
        struct _MODULEINFO
        {
            IntPtr lpBaseOfDll;
            int SizeOfImage;
            IntPtr EntryPoint;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int EnumProcessModules(IntPtr hProcess, out IntPtr[] lphModule, uint cb, out uint lpcbNeeded);

        [DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, out _MODULEINFO lpmodinfo, uint cb);

        [DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern bool EnumProcessModulesEx(IntPtr hProcess, out IntPtr[] lphModule, uint cb, out uint lpcbNeeded, FilterFlags dwFilterFlag);

        static void Main(string[] args)
        {
            //IntPtr hProcess = OpenProcess(ProcessAccessFlags.QueryInformation | ProcessAccessFlags.VirtualMemoryRead, false, 4612);
            //IntPtr[] hMod = new IntPtr[1024];
            //uint cNed = 0;
            //Console.WriteLine(EnumProcessModulesEx(hProcess, out hMod, (uint)hMod.Length, out cNed, FilterFlags.LIST_MODULES_32BIT).ToString());

            Process p = Process.GetProcessById(6720);
            Console.WriteLine(p.MainModule.BaseAddress.ToString("X8"));

            Console.ReadKey();
        }
    }
}
