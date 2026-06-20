/*
 * Created by SharpDevelop.
 * User: SilentArtificer
 * Date: 06/06/2026
 * Time: 13:58
 * USB Relay Timer App
 * v1.7.1.0
 */
using System;
using System.Windows.Forms;

namespace UsbRelayTimerApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}