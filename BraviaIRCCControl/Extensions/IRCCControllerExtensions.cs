using System.Threading.Tasks;

namespace BraviaIRCCControl.Extensions
{
    public static class IRCCControllerExtensions
    {
        #region Public Methods

        public static async Task<bool> ChannelDown(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.ChannelDown);
        }

        public static async Task<bool> ChannelUp(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.ChannelUp);
        }

        public static async Task<bool> Forward(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.Forward);
        }

        public static async Task<bool> Pause(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.Pause);
        }

        public static async Task<bool> Play(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.Play);
        }

        public static async Task<bool> Rewind(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.Rewind);
        }

        public static async Task<bool> Stop(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.Stop);
        }

        public static async Task<bool> VolumeDown(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.VolumeDown);
        }

        public static async Task<bool> VolumeUp(this IRCCController controller)
        {
            return await controller.Send(IRCCCodes.VolumeUp);
        }

        #endregion Public Methods
    }
}