# prism-dialog-keyboard-issue
Demonstrates Xamarin Forms (iOS) bug where keyboard is displayed on opening dialog, using IDialogService.

Steps to repro:

1) Pull the code and build/run on an iPhone simulator or device
2) If you tap the Show Dialog button directly once the UI is shown, a dialog will be displayed, no problems
3) If you tap the Entry and enter some text then hit Return, or touch outside, to dismiss the keyboard, then tap Show Dialog, the keyboard pops back up again with the dialog, which is the issue I'm trying to resolve.


