!pragma warning error all

;--------------------------------
;Add dependence

  !include "MUI2.nsh"
  !include "nsDialogs.nsh"
  !include "LogicLib.nsh"

;--------------------------------
;general

  Unicode true

  Name "WINFONTCHANGER"
  OutFile "wfc_x64x86.exe"

  ;Installation folder
  InstallDir "$DESKTOP\WFC"
  ;Privileges
  RequestExecutionLevel user

;--------------------------------
;--------------------------------
;config interfata

  !define MUI_HEADERIMAGE
  !define MUI_HEADERIMAGE_BITMAP "header.bmp" ;
  !define MUI_ABORTWARNING

  ;show all languages, despite user's codepage
  !define MUI_LANGDLL_ALLLANGUAGES

;--------------------------------

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "LICENSE.txt"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

;--------------------------------
;Languages

  !insertmacro MUI_LANGUAGE "English" ; The first language is the default language
  !insertmacro MUI_LANGUAGE "Romanian"

;--------------------------------
;Reserve Files
  
  ;If you are using solid compression, files that are required before
  ;the actual installation should be stored first in the data block,
  ;because this will make your installer start faster.
  
  !insertmacro MUI_RESERVEFILE_LANGDLL

;--------------------------------
;Installer Functions

Function .onInit

  !insertmacro MUI_LANGDLL_DISPLAY

FunctionEnd

;--------------------------------
Section "*Base app" BaseApp

  SetOutPath "$INSTDIR"
  File /r "..\winfontchanger\bin\Debug\net5.0-windows\*"

SectionEnd
;Descriptions

  ;USE A LANGUAGE STRING IF YOU WANT YOUR DESCRIPTIONS TO BE LANGAUGE SPECIFIC

  ;Assign descriptions to sections
  !insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
    !insertmacro MUI_DESCRIPTION_TEXT ${BaseApp} "The main application. You use it to change the UI fonts, thats all."
  !insertmacro MUI_FUNCTION_DESCRIPTION_END

 
;--------------------------------