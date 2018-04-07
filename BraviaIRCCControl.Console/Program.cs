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
            System.Console.Write("Pin Code ? ");
            string pin = System.Console.ReadLine();
            if (string.IsNullOrWhiteSpace(pin)) { pin = "0000"; }

            IRCCController control = new IRCCController(hostname, pinCode: pin);
            IRCCCodesExtension.InitializeController(control);

            Task.Factory.StartNew(async () =>
            {

                await control.Send(IRCCCodes.VolumeUp);
                await IRCCCodes.VolumeUp.Send();
                await IRCCCodes.VolumeUp.Send(control);
                await control.VolumeUp();

                await control.Send(IRCCCodes.VolumeDown);
                await IRCCCodes.VolumeDown.Send();
                await IRCCCodes.VolumeDown.Send(control);
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