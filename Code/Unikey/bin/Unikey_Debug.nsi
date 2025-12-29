!define /date MyTIMESTAMP "%Y-%m-%d@%H-%M"
Name "Unikey"
OutFile "Unikey_Setup-${MyTIMESTAMP}.exe"
InstallDir "$DESKTOP\Unikey"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Debug\net9.0-windows\*.dll"
  File /r ".\Debug\net9.0-windows\*.exe"
  File /r ".\Debug\net9.0-windows\*.json"

SectionEnd ; end the section

