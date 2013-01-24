using System;

using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace ButtonsSettings
{
    /*
    [HKEY_LOCAL_MACHINE\Software\Microsoft\Shell\Keys\40C1]
    "Flags"=dword:00000000
    "ResetCmd"="\"\\Windows\\AppButtons\\Record.lnk\" -b"
    "Icon"="\\windows\\hotvoice.exe, 0"
    "Name"="Record Button"
    @="\"\\Windows\\AppButtons\\Record.lnk\" -b"

    [HKEY_LOCAL_MACHINE\Software\Microsoft\Shell\Keys\40C2]
    "Flags"=dword:00000000
    "ResetCmd"="\"\\Windows\\AppButtons\\Record.lnk\" -b"
    "Icon"="\\windows\\hotvoice.exe, 0"
    "Name"="Record Button"
    @="\"\\Windows\\AppButtons\\Record.lnk\" -b"
    */
    public class ShellKeys
    {
        public static string[] keyID {
            get{
                return new string[] { "40C1", "40C2", "40C3", "40C4", "40C5", "40C6" };
            }
        }

        public ShellKey[] _shellKeys;
        public ShellKeys()
        {
            try
            {
                //create a new list of shellkeys
                _shellKeys = new ShellKey[6];
                int iCnt = 0;
                foreach (string sKeyVal in keyID)
                {
                    ShellKey sk = new ShellKey();
                    sk.loadKey(sKeyVal, ref sk);
                    if (sk.exists)
                    {
                        _shellKeys[iCnt] = sk;
                        System.Diagnostics.Debug.WriteLine(sk.dumpShellKey());
                        iCnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public class ShellKey:IDisposable
        {
            private static RegistryKey _rKey;
            private RegistryKey rKey
            {
                get
                {
                    if (_rKey != null)
                    {
                        System.Diagnostics.Debug.WriteLine("#### rKey=" + _rKey.ToString());
                        return _rKey;
                    }
                    else
                    {
                        _rKey = Registry.LocalMachine;//.OpenSubKey(sSubKey, true);
                        System.Diagnostics.Debug.WriteLine("#### NEW rKey=" + _rKey.ToString());
                        return _rKey;
                    }

                }
            }
            public static string sSubKey = @"Software\Microsoft\Shell\Keys";

//            string sSubKey = @"Software\Microsoft\Shell\Keys";
            //RegistryKey rKey = null;

            int Flags = 0;
            public string ResetCmd = "";
            public string Icon = "\"\\Windows\\fexplore.exe\"";
            public string @Name = "AppKey";
            public string @default = "\"\\Windows\\fexplore.exe\"";

            /// <summary>
            /// does the key already exist in registry?
            /// </summary>
            public bool exists = false;
            
            int keyVal = 0x40c1;

            List<string> knownSubKeys;

            public ShellKey()
            {
                knownSubKeys = new List<string>();
            }
            public ShellKey(int keyValue)
            {
                knownSubKeys = new List<string>();
                keyVal = keyValue;
                @Name = "Button" + (keyVal - 0x40c0).ToString();
            }
            public ShellKey(string sKeyValue)
            {
                knownSubKeys = new List<string>();
                keyVal = Convert.ToInt16(sKeyValue, 16);
                @Name = "Button" + (keyVal - 0x40c0).ToString();
            }

            public void Dispose()
            {
                if (_rKey != null)
                {
                    _rKey.Flush();
                    _rKey.Close();
                    _rKey = null;
                }
            }

            public override string ToString()
            {
                int i = keyVal -0x40c0;
                return "Button "+i.ToString();
                
            }

            public bool removeKey()
            {
                bool bRet = false;
                //RegistryKey rKey = null;
                try
                {
                    string sVal = this.keyVal.ToString("X");
                    if (existsShellKey(sVal))
                    {
                        //while (rKey != null)
                        //{
                        //    rKey.Close();
                        //    rKey = null;
                        //    //rKey=Registry.LocalMachine.OpenSubKey(sSubKey, true);
                        //}
                        
                        //rKey = Registry.LocalMachine.OpenSubKey(sSubKey, true);
                        //rKey.DeleteSubKeyTree(sVal);

                        rKey.OpenSubKey(sSubKey+ @"\" + sVal,true);// sSubKey + @"\" + sVal, true);

                        try { rKey.DeleteValue(""); }
                        catch (Exception) { }
                        try { rKey.DeleteValue("Icon"); }
                        catch (Exception) { }
                        try { rKey.DeleteValue("ResetCmd"); }
                        catch (Exception) { }
                        try { rKey.DeleteValue("Name"); }
                        catch (Exception) { }
                        try { rKey.DeleteValue("Flags"); }
                        catch (Exception) { }
                        rKey.Flush();
                        //rKey.Close();

                        rKey.OpenSubKey(sSubKey, true);
                        rKey.DeleteSubKey(sVal);// sSubKey + @"\" + sVal);
                    }
                    bRet = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: removeKey('" + this.keyVal.ToString("X") + "')" + ex.Message);
                }
                finally
                {
                    rKey.Close();
                }
                return bRet;
            }

            public bool saveKey()
            {
                bool bRet = false;
                //RegistryKey rKey = null;
                try
                {
                    string sVal = this.keyVal.ToString("X");
                    if (existsShellKey(sVal))
                    {
                        rKey.OpenSubKey(sSubKey + @"\" + sVal, true);
                        if (writeString("", @default) &&
                            writeInt("Flags", (uint)Flags) &&
                            writeString("ResetCmd", ResetCmd) &&
                            writeString("Icon", Icon) &&
                            writeString("Name", Name)
                            )
                            bRet = true;
                        rKey.Flush();
                        //rKey.Close();
                    }
                    else
                    {
                        rKey.CreateSubKey(sSubKey + @"\" + sVal);
                        if (writeString("", @default) &&
                            writeInt("Flags", (uint)Flags) &&
                            writeString("ResetCmd", ResetCmd) &&
                            writeString("Icon", Icon) &&
                            writeString("Name", Name)
                            )
                            bRet = true;
                        rKey.Flush();
                        //rKey.Close();

                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: saveKey('" + this.keyVal.ToString("X") + "')" + ex.Message);
                }
                finally
                {
                    rKey.Close();
                }
                return bRet;
            }

            public ShellKey addKey(string sKeyVal)
            {
                List<string> keyVals = new List<string>(keyID);
                if (!keyVals.Contains(sKeyVal))
                    return null;
                ShellKey sk = new ShellKey(sKeyVal);
                if (existsShellKey(sKeyVal))
                    return loadKey(sKeyVal, ref sk);
                else
                {
                    sk.saveKey();
                    return sk;
                }
            }

            /// <summary>
            /// read key from registry
            /// </summary>
            /// <param name="sKeyVal"></param>
            /// <returns></returns>
            public ShellKey loadKey(string sKeyVal, ref ShellKey sk)
            {
                //RegistryKey rKey = null; 
                if (existsShellKey(sKeyVal))
                {
                    try
                    {
                        rKey.OpenSubKey(sSubKey + @"\" + sKeyVal, true);
                        sk.exists = true;
                        sk.@default = readString("");
                        sk.Flags = readInt("Flags");
                        sk.ResetCmd = readString("ResetCmd");
                        sk.Icon = readString("Icon");
                        sk.keyVal = Convert.ToInt32(sKeyVal, 16);
                        sk.Name = readString("Name");
                        //rKey.Close();
                    }
                    catch (Exception) { }
                    finally
                    {
                        rKey.Close();
                    }
                }
                else
                {
                    sk.exists = false;
                }
                return sk;
            }

            public string dumpShellKey()
            {
                StringBuilder sb = new StringBuilder( string.Format("keyID={0:x}, Name='{6}', exists={1}, default='{2}', flags=0x{3}, resetCmd='{4}', icon='{5}'",
                    keyVal, exists, @default, Flags, ResetCmd, Icon, Name));
                return sb.ToString();
            }

            bool existsShellKey(string sKeyValue)
            {
                bool bRet = false;
                //RegistryKey rKey = null;
                try
                {
                    if (knownSubKeys.Contains(sKeyValue))
                        return true;
                    //open main key tree
                    rKey.OpenSubKey(sSubKey, true);
                    if (rKey == null)
                        return false;
                    string[] sSubKeys = rKey.GetSubKeyNames();
                    string search = "";
                    foreach (string s in sSubKeys)
                    {
                        knownSubKeys.Add(s);
                        search += s + " ";
                    }
                    if (search.IndexOf(sKeyValue, 0, StringComparison.OrdinalIgnoreCase) != -1)
                        bRet = true;
                    else
                        bRet = false;
                }
                catch (Exception) { }
                finally
                {
                    if (rKey != null)
                    {
                        rKey.Close();
                    }
                }
                return bRet;
            }
            //#########################################################################
            string readString(string sValue)
            {
                string sRet = null;
                try
                {
                    string s = (string)rKey.GetValue(sValue);
                    if (s != null)
                        sRet = s;
                    else
                        sRet = "";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: readString('"+sValue+"')" + ex.Message);
                    sRet = "";
                }
                return sRet;
            }

            int readInt(string sValue)
            {
                int iRet = 0;
                try
                {
                    int iVal = (int)rKey.GetValue(sValue,0xCab1e);
                    if (iVal != 0xCab1e)
                        iRet = iVal;
                    else
                        iRet = 0;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: readInt('" + sValue + "')" + ex.Message);
                    iRet = 0;
                }
                return iRet;
            }

            bool writeString(string sValue, string valueString)
            {
                bool bRet = false;
                try
                {
                    string s = valueString;
                    rKey.SetValue(sValue, s, RegistryValueKind.String);
                    rKey.Flush();
                    bRet = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: writeString('" + sValue + "')" + ex.Message);
                }
                return bRet;

            }
            bool writeInt(string sValue, UInt32 iValue)
            {
                bool bRet = false;
                try
                {
                    rKey.SetValue(sValue, iValue, RegistryValueKind.DWord);
                    rKey.Flush();
                    bRet = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception: writeInt('" + sValue + "')" + ex.Message);
                }
                return bRet;

            }
        }
        //great stuff by http://ideas.dalezak.ca/2008/11/enumgetvalues-in-compact-framework.html
        /*
            usage:
                foreach (DayOfWeek dayOfWeek in GetValues(new DayOfWeek())) {}
        */
        public static IEnumerable<Enum> GetValues(Enum enumeration)
        {
            List<Enum> enumerations = new List<Enum>();
            foreach (System.Reflection.FieldInfo fieldInfo in enumeration.GetType().GetFields(
                  System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public))
            {
                enumerations.Add((Enum)fieldInfo.GetValue(enumeration));
            }
            return enumerations;
        }

    }
}
