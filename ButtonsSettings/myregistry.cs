using System;

using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace ButtonsSettings
{
    class myregistry
    {
        [DllImport("coredll.dll", SetLastError=true)]
        public static extern int RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions,int samDesired, out IntPtr phkResult);

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern int RegDeleteKey(IntPtr hKey, string lpSubKey);

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern int RegDeleteKey(UIntPtr hKey, string lpSubKey);
        
        [DllImport("coredll.dll")]
        public static extern int RegCloseKey(IntPtr hKey);

        public static int RegOpenKeyEx(UIntPtr hKey, string lpSubKey, out IntPtr phkResult){
            int iRes = RegOpenKeyEx(hKey, lpSubKey, 0, 0, out phkResult);
            if (iRes != 0)
                System.Diagnostics.Debug.WriteLine("RegOpenKeyEx: LastError=" + Marshal.GetLastWin32Error().ToString());
            return iRes;
        }

        //const UInt32 HKEY_LOCAL_MACHINE = 0x80000002;
        public static int RegDelKey(string lpSubKey)
        {
            // 0x80000002
            UIntPtr HKEY_LOCAL_MACHINE = new UIntPtr(0x80000002);// IntPtr (-2147483646);
            IntPtr hKey;
            int iRes = RegOpenKeyEx(HKEY_LOCAL_MACHINE, lpSubKey, out hKey);
            iRes = RegDeleteKey(hKey, lpSubKey);
            if (iRes != 0)
                System.Diagnostics.Debug.WriteLine("RegDelKey: LastError=" + Marshal.GetLastWin32Error().ToString());
            
            RegCloseKey(hKey);
            return iRes;
        }

        public static int RegDelKey(string lpSubKey, string sKey)
        {
            // 0x80000002
            UIntPtr HKEY_LOCAL_MACHINE = new UIntPtr(0x80000002);// IntPtr (-2147483646);
            IntPtr hKey;
            int iRes = RegOpenKeyEx(HKEY_LOCAL_MACHINE, lpSubKey, out hKey);
            iRes = RegDeleteKey(hKey, sKey);
            if (iRes != 0)
                System.Diagnostics.Debug.WriteLine("RegDelKey: LastError=" + Marshal.GetLastWin32Error().ToString());
            RegCloseKey(hKey);
            return iRes;
        }    }
}
