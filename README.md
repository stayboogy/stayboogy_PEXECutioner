# stayboogy_PEXECutioner

### user customizable, single exe, single configfile, WinPE Shell & Launcher for both x86/x64 in the same exe

#### Video Demonstration

https://rumble.com/v3zu7q4-pexecutioner-winpe-launcher-shell-stayboogy-open-source-single-exe.html

## How To Use

### 1) your WinPe must have these components added to it

```Javascript
NetFx
Dot3Svc
```

### 2) optionally add these components for full system support

```javascript
WMI 
Scripting
PowerShell
StorageWMI
DismCmdlets
EnhancedStorage
FMAPI
FontSupport-WinRE
PlatformId
WDS-Tools
WinReCfg
lp
```

### 3) Modify WinPE\Windows\System32\winpeshl.ini like so

```javascript
[LaunchApp]
AppPath = X:\Path\To\Where\You\Copied\PEXECutioner\PEXECutioner.exe
```

### 4) copy "PEXECutioner.exe" and "PEXECutioner.exe.config" to the location inside your WinPE source you specified in step 3

### 5) edit "PEXECutioner.exe.config" to correspond to the tools' paths' you would like to be able to run with just a click of a button. 

```javascript
    <add key="button#" value="X:\Path\To\Some\Exe\Or\Task\Or\CMD\ETC"/>
    <add key="button#_title" value="Whatever You Want it Called - Limited Space"/>
```
### So Buttons 1 - 3 (and so on to 16) would be defined as (examples):

```javascript
<appsettings> 

    <add key="button1" value="taskmgr.exe"/>
    <add key="button1_title" value="TASKMGR"/>
    
    <add key="button2" value="cmd.exe"/>
    <add key="button2_title" value="CMD"/>

    <add key="button3" value="regedit.exe"/>
    <add key="button3_title" value="REGEDIT"/>
    
</appsettings>
```

### Buttons can defined in any order or there can be any number of buttons from 1 to 16

### 6) rebuild your source WinPE

### 7) test, tweak, verify, and enjoy!

