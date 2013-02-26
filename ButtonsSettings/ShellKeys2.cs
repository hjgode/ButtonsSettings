using System;

using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace ButtonsSettings
{
    class ShellKeys2:IDisposable
    {
        /// <summary>
        /// a list with all shell keys from registry
        /// </summary>
        List<ShellKeyItem> shellKeyItems = new List<ShellKeyItem>();
        /// <summary>
        /// a list of all know shell key values
        /// </summary>
        string[] _sKeyList = new string[] { "40C1", "40C2", "40C3", "40C4", "40C5", "40C6", "40CF" };
        /// <summary>
        /// an array with all existing shell keys
        /// </summary>
        string[] shellKeysList = null;
        /// <summary>
        /// a list with not defined shell keys
        /// </summary>
        List<string> shellNewKeysList = new List<string>();
        public List<string> newKeysList
        {
            get {
                refreshKeys();
                return shellNewKeysList; 
            }
        }

        public ShellKeys2()
        {
            refreshKeys();
        }

        public int refreshKeys()
        {
            shellKeysList = getShellKeysArray();
            shellKeyItems = getAllShellKeys();
            shellNewKeysList.Clear();
            foreach (ShellKeyItem ski in shellKeyItems)
            {
                if (!ski.bFromReg)
                    shellNewKeysList.Add(ski.ShellKeyValue);
            }
            return shellKeysList.Length;
        }

        public void Dispose()
        {
        }

        public string[] keyIDList
        {
            get
            {
                return _sKeyList;
            }
        }

        public ShellKeyItem[] getAllShellKeysArray()
        {
            return getAllShellKeys().ToArray();
        }
        public List<ShellKeyItem> getShellKeyItems()
        {
            List<ShellKeyItem> keyItems = new List<ShellKeyItem>();
            foreach (string s in _sKeyList)
            {
                ShellKeyItem ski = new ShellKeyItem();
                if (existsKey(s))
                {
                    //read/set values
                    ski.bFromReg = true;
                    ski.ShellKeyValue = s.ToUpper();
                    ski.@default = readString(s, ""); ;
                    ski.Flags = readInt(s, "Flags");
                    ski.Icon = readString(s, "Icon");
                    ski.@Name = readString(s, "Name");
                    ski.ResetCmd = readString(s, "ResetCmd");
                    ski.ShellKeyValue = s;
                    keyItems.Add(ski);
                    System.Diagnostics.Debug.WriteLine(ski.ToString());
                }
            }
            return keyItems;
        }
        public List<ShellKeyItem> getAllShellKeys()
        {
            //read all possible shellkeys
            //refreshKeys();
            shellKeyItems.Clear();
            foreach (string s in _sKeyList)
            {
                ShellKeyItem ski = new ShellKeyItem();
                if (existsKey(s))
                {
                    //read/set values
                    ski.bFromReg = true;
                    ski.ShellKeyValue = s.ToUpper();
                    ski.@default = readString(s, ""); ;
                    ski.Flags = readInt(s, "Flags");
                    ski.Icon = readString(s, "Icon");
                    ski.@Name = readString(s, "Name");
                    ski.ResetCmd = readString(s, "ResetCmd");
                    ski.ShellKeyValue = s;
                    shellKeyItems.Add(ski);
                    System.Diagnostics.Debug.WriteLine(ski.ToString());
                }
                else
                {
                    ski.bFromReg = false;
                    ski.ShellKeyValue = s;
                    shellKeyItems.Add(ski);
                    ski.ShellKeyValue = s.ToUpper();
                }
            }
            return shellKeyItems;
        }

        //public List<ShellKeyItem> getShellKeys()
        //{
        //    //read all shellkeys
        //    RegistryKey rKey = Registry.LocalMachine.OpenSubKey(ShellKeyItem.sMainSubKey);
        //    string[] sKeys = rKey.GetSubKeyNames();
        //    rKey.Close();
        //    foreach (string s in sKeys)
        //    {
        //        ShellKeyItem ski = new ShellKeyItem();
        //        //read values
        //        //default value
        //        ski.ShellKeyValue = s.ToUpper();
        //        ski.@default = readString(s, ""); ;
        //        ski.Flags = readInt(s, "Flags");
        //        ski.Icon = readString(s, "Icon");
        //        ski.@Name = readString(s, "Name");
        //        ski.ResetCmd = readString(s, "ResetCmd");
        //        shellKeyItems.Add(ski);
        //        System.Diagnostics.Debug.WriteLine(ski.ToString());
        //    }
        //    return shellKeyItems;
        //}

        public bool existsKey(string sKeyValue)
        {
            bool bRet = false;
            for (int i = 0; i < shellKeysList.Length; i++)
            {
                if (shellKeysList[i].ToUpper() == sKeyValue.ToUpper())
                {
                    bRet = true;
                    break;//exit for loop
                }
            }
            return bRet;
        }
        public string[] getShellKeysArray()
        {
            string[] strings=null;
            RegistryKey rKey = null;
            try
            {
                rKey = Registry.LocalMachine.OpenSubKey(ShellKeyItem.sMainSubKey);
                strings = rKey.GetSubKeyNames();                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" + ex.Message + "' in getShellKeysArray()");
            }
            finally
            {
                rKey.Close();
            }
            return strings;
        }
        public List<string> getShellKeysList()
        {
            List<string> sList = new List<string>();
            string[] sArr = getShellKeysArray();
            for (int i = 0; i < sArr.Length; i++)
                sList.Add(sArr[i]);
            return sList;
        }
        public static bool delShellKey(string subKey)
        {
            bool bRet = false;
            try
            {
                //if(myregistry.RegDelKey(ShellKeyItem.sMainSubKey + @"\" + subKey)==0)
                if (myregistry.RegDelKey(ShellKeyItem.sMainSubKey, subKey) == 0)
                    bRet = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" + ex.Message + "' in delShellKey() for '" + subKey + "'");
            }
            return bRet;
        }
        string readString(string subKey, string value)
        {
            string sRet = "";
            RegistryKey rKey=null;
            try
            {
                rKey=Registry.LocalMachine.OpenSubKey(ShellKeyItem.sMainSubKey + @"\" + subKey);
                sRet = (string)rKey.GetValue(value);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" + ex.Message + "' in readString() for '" + subKey + "', '" + value + "'");
            }
            finally
            {
                try
                {
                    rKey.Close();
                }
                catch (Exception) { }
            }
            return sRet;
        }
        int readInt(string subKey, string value)
        {
            int iRet = 0;
            RegistryKey rKey = null;
            try
            {
                rKey = Registry.LocalMachine.OpenSubKey(ShellKeyItem.sMainSubKey + @"\" + subKey);
                iRet = (int)rKey.GetValue(value);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" + ex.Message + "' in readInt() for '" + subKey + "', '" + value + "'");
            }
            finally
            {
                try { rKey.Close(); }
                catch (Exception) { }
            }
            return iRet;
        }
    }
    public class ShellKeyItem
    {
        public static string sMainSubKey = @"Software\Microsoft\Shell\Keys";
        [Flags]
        public enum eFlags
        {
            useApp=0x0000,
            showStartMenu = 0x0001,
            showSIP=0x0002,
            showHome=0x0004,
            scrollRight=0x0008,
            scrollUp=0x0005,
            scrollDown=0x0006,
            scrollLeft=0x0007,
            disableKey=0x0009,
            okClose = 0x000A,
            showContextMenu=0x000b,
            rotateScreen=0x000c
        }
        /* //Flags as of http://www.smartphonemag.com/cms/blog/9/more-programmershackers-stuff-along-with-some-cool-pocket-loox-7xx-hold-button-tips-more-pock
        All bits off: the default mode (button associations work as configured: invoking an external program defined in the Default value of the given registry key)
        Bit 1 (lowermost bit; that is, putting 00000001 in the given button's flah): invoke Start menu
        Bit 2 (00000002): bring up the current SIP
        Bit 3 (00000004): switch to the Today screen
        Bit 4 (00000008): scroll right

        Bit combinations:
        Bit 1+3 (00000005): scroll up
        Bit 2+3 (00000006): scroll down
        Bit 1+2+3 (00000007): scroll left
        Bit 1+4 (00000009): completely disable (a.k.a. <None>)
        Bit 2+4 (0000000A): OK/Close
        Bit 1+2+4 (0000000B ): Context Menu
        Bit 3+4 (0000000C): screen orientation change in WM2003SE+
        */
        public int Flags = 0;
        public string ResetCmd = "";
        public string Icon = "\"\\Windows\\fexplore.exe\"";
        public string @Name = "AppKey";
        public string @default = "\"\\Windows\\fexplore.exe\"";
        /// <summary>
        /// one of the shell key values from 40C1 to 40C6
        /// </summary>
        public string ShellKeyValue = "40C1";
        public bool bFromReg = false;

        public bool save2Reg()
        {
            int bRet=0;
            bRet += string2Reg("ResetCmd", ResetCmd);
            bRet += string2Reg("Icon", Icon);
            bRet += string2Reg("Name", @Name);
            bRet += string2Reg("", @default);
            bRet += int2Reg("Flags", Flags);
            return (bRet==0);
        }

        int string2Reg(string sName, string sValue)
        {
            int bRet=1;
            RegistryKey rKey=null;
            try
            {
                rKey = Registry.LocalMachine.CreateSubKey(sMainSubKey + @"\" + ShellKeyValue);
                rKey.SetValue(sName, sValue, RegistryValueKind.String);
                bRet = 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" +ex.Message+ "' in string2Reg() for name='" + sName + "', value='" + sValue + "'");
            }
            finally{
                rKey.Close();
            }
            return bRet;
        }
        int int2Reg(string sName, int iValue)
        {
            int bRet = 1;
            RegistryKey rKey = null;
            try
            {
                rKey = Registry.LocalMachine.CreateSubKey(sMainSubKey + @"\" + ShellKeyValue);
                rKey.SetValue(sName, iValue, RegistryValueKind.DWord);
                bRet = 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception '" + ex.Message + "' in string2Reg() for name='" + sName + "', value='" + iValue.ToString() + "'");
            }
            finally
            {
                rKey.Close();
            }
            return bRet;
        }
        public string dumpToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("keyval='" + ShellKeyValue + "'; ");
            sb.Append("default='" + @default + "'; ");
            sb.Append("flags='0x" + Flags.ToString("X") + "'; ");
            sb.Append("name='" + @Name + "'; ");
            sb.Append("resetcmd='" + ResetCmd + "'; ");
            sb.Append("icon='" + Icon + "'; ");
            //sb.Append("\r\n");

            return sb.ToString();
        }
        public override string ToString()
        {
            return ShellKeyValue;
            //return base.ToString();
        }
    }
}
