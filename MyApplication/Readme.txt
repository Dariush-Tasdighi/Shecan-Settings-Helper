**************************************************
این مینی دوره، مناسب چه کسانی می‌باشد؟
**************************************************
Automation Team
Security Team
System Programmers
Gammers
**************************************************

**************************************************
کاری که باید به صورت دستی انجام دهیم
**************************************************
Windows + R -> ncpa.cpl
**************************************************

**************************************************
کاری که باید به صورت دستی انجام دهیم
**************************************************
Get-DnsClientServerAddress

Set-DnsClientServerAddress -InterfaceIndex ????? -ServerAddresses ('178.22.122.100','185.51.200.2')

Disable-NetAdapter -Name Wi-Fi -Confirm:$false

Enable-NetAdapter -Name Wi-Fi -Confirm:$false

Set-DnsClientServerAddress -InterfaceIndex ????? -ResetServerAddresses
**************************************************

**************************************************
کاری که می‌خواهیم به صورت مکانیزه انجام دهیم
**************************************************
Get-DnsClientServerAddress

Get-DnsClientServerAddress | Where-Object -Property "InterfaceAlias" -EQ -Value "Wi-Fi"

Get-DnsClientServerAddress | Where-Object -Property "InterfaceAlias" -EQ -Value "Wi-Fi" | Where-Object -Property "AddressFamily" -EQ -Value "2"

Get-DnsClientServerAddress | Where-Object -Property "InterfaceAlias" -EQ -Value "Wi-Fi" | Where-Object -Property "AddressFamily" -EQ -Value "2" | Select-Object "InterfaceIndex"

Set-DnsClientServerAddress -InterfaceIndex ????? -ServerAddresses ('178.22.122.100','185.51.200.2')

Set-DnsClientServerAddress -InterfaceIndex ????? -ResetServerAddresses

Disable-NetAdapter -Name Wi-Fi -Confirm:$false

Enable-NetAdapter -Name Wi-Fi -Confirm:$false
**************************************************

**************************************************
- Note: This application should be run as administrator!
**************************************************
