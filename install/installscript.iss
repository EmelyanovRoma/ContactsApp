#define MyAppName "ContactsApp"
#define MyAppVersion "1.0"
#define MyAppPublisher "Emelyanov Roman"
#define MyAppURL "https://github.com/EmelyanovRoma"
#define MyAppExeName "ContactsApp.View.exe"
#define MyAppIcon = "..\src\ContactsApp\ContactsApp.View\ContactsApp_96x96.ico"
#define InstallerFileName "setup " + GetDateTimeString('dd-mm-yyyy hh-nn-ss', '-', ':')
#define PathToFiles = "..\src\ContactsApp\ContactsApp.View\bin\Release\net6.0-windows"

[Setup]
AppId = {{50912B57-67B8-4A35-A0C2-308D01038E0A}
AppName = {#MyAppName}
AppVersion = {#MyAppVersion}
AppPublisher = {#MyAppPublisher}
AppPublisherURL = {#MyAppURL}
AppSupportURL = {#MyAppURL}
AppUpdatesURL = {#MyAppURL}
DefaultDirName = {autopf}\Emelyanov\{#MyAppName}
DefaultGroupName = {#MyAppName}
LicenseFile = "..\LICENSE"
OutputDir = .\Output
OutputBaseFilename = {#InstallerFileName}
SetupIconFile = {#MyAppIcon}
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression = lzma
SolidCompression = yes
WizardStyle = modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#PathToFiles}\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PathToFiles}\*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PathToFiles}\*.json"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

