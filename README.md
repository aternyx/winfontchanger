# winfontchanger
Easy to use display font changer, for those who became bored of Segoe UI and don't have registry experience

![](https://img001.prntscr.com/file/img001/J23Dfu73ToGkfP49a8AC-w.png)

## USAGE
This program must be started with elevation _(Administrator privileges)_ else the program may not work.

To change the font, type in the desired font family existing in your PC in "Selected Font" textbox. Other than typing in manually you can also select the font via <kbd>...</kbd> button.
Then select the Segoe UI fonts to be replaced with the new one. Click on <kbd>Execute</kbd> to proceed with default font replacement. You will be asked if you **have a restore point created** before proceeding as it may cause corruption if PC is shutdown during process or something else goes wrong.

After the process is finished (usually done in less than 2 seconds depending on hardware) you will be prompted to restart your PC so the changes will take effect.

## FaQ
1. How do I reset the default font to the original Segoe UI?
   > Press the <kbd>Reset to Default</kbd> button next to the <kbd>Execute</kbd> button.
2. Why I cannot start the program without admin elevation?
   > As I mentioned above, elevation is mandatory to change the font. The program needs to write required strings in the Windows Registry to be able to change the font. Without elevation this may not be possible.
3. I am afraid of some kind of corruption, how do I prevent this?
   > It is highly suggested to create a restore point, just go to `Control Panel » Recovery » Configure Restore Point » Create`. Name it "Before Font Changing" or something else. If everything got wrong, you can boot into Windows Recovery and restore the restoration point you had just created.
