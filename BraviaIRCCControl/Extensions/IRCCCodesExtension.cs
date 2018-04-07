using BraviaIRCCControl.Core;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BraviaIRCCControl.Extensions
{
    /// <summary>
    /// Extensions for enum "IRCCCodes"
    /// </summary>
    public static class IRCCCodesExtension
    {
        /// <summary>
        /// Controller used by extensions
        /// </summary>
        public static IRCCController Controller { get; private set; }

        #region Public Methods

        /// <summary>
        /// Get the code value
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetCode(this IRCCCodes code)
        {
            MemberInfo memberInfo = typeof(IRCCCodes).GetMember(code.ToString())
                                              .FirstOrDefault();

            if (memberInfo != null)
            {
                IRCCCodeAttribute attribute = (IRCCCodeAttribute)
                             memberInfo.GetCustomAttributes(typeof(IRCCCodeAttribute), false)
                                       .FirstOrDefault();
                return attribute.Code;
            }

            return null;
        }

        /// <summary>
        /// Initialize a new controller that will be used by the extensions once and for all
        /// </summary>
        /// <param name="controller"></param>
        public static void InitializeController(IRCCController controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        /// <summary>
        /// Initialize a new controller that will be used by the extensions
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="port"></param>
        /// <param name="pinCode"></param>
        public static void InitializeController(string hostName, int port = 80, string pinCode = "0000")
        {
            Controller = new IRCCController(hostName, port, pinCode);
        }

        /// <summary>
        /// Send a code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<bool> Send(this IRCCCodes code)
        {
            if (Controller == null)
            {
                throw new InvalidDataException("A controller must be initialized");
            }

            return await Controller.Send(code);
        }

        /// <summary>
        /// Send a code with a specific controller
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<bool> Send(this IRCCCodes code, IRCCController controller)
        {
            if (controller == null)
            {
                throw new InvalidDataException("A controller must be defined");
            }

            return await controller.Send(code);
        }

        #endregion Public Methods
    }
}