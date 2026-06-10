🚀 UsbRelayTimerApp v1.7.0.5

UsbRelayTimerApp is a C# WinForms application that allows you to easily control USB HID relay modules via your computer.
This version makes it possible to manage the relay with both manual control and timer functions.

🔧 Features

Manual ON/OFF:
Turn the relay on and off with dedicated buttons.
Timer function:
Keep the relay on for a specific time, and automatically turn it off when the time is up.
Pause/Resume: Pause the timer and resume it from where it left off.
Reset: Reset the timer.
Status indicator: Monitor the remaining time and relay status with Label and ProgressBar.
relayIsOn flag: Monitors the relay status and prevents unnecessary commands.

📦 Contents

Source code (.cs, .csproj, App.config)
Compiled Windows application (UsbRelayTimerApp.exe)

🖥️ Requirements

.NET Framework 4.x
Single channel USB HID relay module
Relay control program (CommandApp_USBRelay.exe)

📌 Notes

Don't forget to edit the App.config file according to your own relay commands.
This version is for testing purposes only.
