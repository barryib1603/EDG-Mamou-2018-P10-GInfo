; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EDG_MAMOU"
#define MyAppVersion "1.0"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "EDG_Mamou.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B1E40EB7-B080-4A16-8EAB-2351E85546ED}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
LicenseFile=C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\cl�vf.txt
OutputDir=C:\Users\ACER\EDG_SETUP_VF
OutputBaseFilename=setup.exe
SetupIconFile=C:\Users\ACER\Desktop\edg_2_11.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\EDG_Mamou.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ACER\Desktop\EDG_MAMOU_SETUP\SETUP.iss"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

