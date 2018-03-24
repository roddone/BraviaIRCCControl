using BraviaIRCCControl.Extensions;
using System.Threading.Tasks;

namespace BraviaIRCCControl.Console
{
    public class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            System.Console.Write("Host name ? ");
            string hostname = System.Console.ReadLine();

            IRCCController control = new IRCCController(hostname);

            Task.Factory.StartNew(async () =>
            {
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.Send(IRCCCodes.VolumeUp);
                await control.VolumeUp();

                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.Send(IRCCCodes.VolumeDown);
                await control.VolumeDown();

                await control.Send(IRCCCodes.HDMI1);
                await control.Send(IRCCCodes.HDMI2);
                await control.Send(IRCCCodes.HDMI3);
                await control.Send(IRCCCodes.HDMI4);
            });

            System.Console.WriteLine("Press enter to quit.");
            System.Console.ReadLine();
        }

        #endregion Private Methods
    }
}