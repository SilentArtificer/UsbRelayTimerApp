🚀 UsbRelayTimerApp v1.7.1.0

UsbRelayTimerApp is a C# WinForms application that allows you to easily control USB HID relay modules via your computer.
This version makes it possible to manage the relay with both manual control and timer functions.

🔧 Features

<b>Manual ON/OFF:</b>  
Turn the relay on and off with dedicated buttons.

<b>Delay function:</b>  
Define the waiting time before opening the relay.

<b>Timer function:</b>  
Keep the relay on for a specific time, and automatically turn it off when the time is up.

<b>Pause/Resume:</b>  
Pause the timer and resume it from where it left off.

<b>Reset:</b>  
Reset the timer.

<b>Status indicator:</b>  
Monitor the remaining time and relay status with Label and ProgressBar.

<b>relayIsOn flag:</b>  
Monitors the relay status and prevents unnecessary commands.

📦 Contents

Source code (.cs, .csproj, App.config)  
Compiled Windows application (UsbRelayTimerApp.exe)

🖥️ Requirements
<ul>
<li>winXP x86 or later</li>
<li>.NET Framework 4.x</li>
<li>Single channel USB HID relay module</li>
<li>Relay control program (CommandApp_USBRelay.exe)</li>
</ul>

📌 Notes

Don't forget to edit the <b>UsbRelayTimerApp.exe.config</b> file according to your own relay commands, command program name and path.   
It is your responsibility to use this program in critical applications.
