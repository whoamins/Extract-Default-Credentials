using Microsoft.Win32;

const string regKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";

if (OperatingSystem.IsWindows())
{
    using var winLogonRegistryKey = Registry.LocalMachine.OpenSubKey(regKey);

    if (winLogonRegistryKey != null)
    {
        Console.WriteLine($"Default Domain Name: {winLogonRegistryKey.GetValue("DefaultDomainName")}");
        Console.WriteLine($"Default User Name: {winLogonRegistryKey.GetValue("DefaultUserName")}");
        Console.WriteLine($"Default Password: {winLogonRegistryKey.GetValue("DefaultPassword")}");
        Console.WriteLine($"AutoAdminLogon: {winLogonRegistryKey.GetValue("AutoAdminLogon")}");
    }
}
else
{
    Console.WriteLine("It doesn't work on Linux :)");
}