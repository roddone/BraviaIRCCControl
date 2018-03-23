using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraviaIRCCControl.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Host name ? ");
            string hostname = System.Console.ReadLine();
            IRCCController control = new IRCCController(hostname);

            Task.Factory.StartNew(async () =>
            {
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeUp);

                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
                await Task.Delay(1000);
                await control.Send(IRCCCodes.VolumeDown);
            });

            System.Console.WriteLine("Press enter to quit.");
            System.Console.ReadLine();
        }
    }
}
