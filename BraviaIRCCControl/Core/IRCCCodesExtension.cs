using System.Linq;
using System.Reflection;

namespace BraviaIRCCControl.Core
{
    internal static class IRCCCodesExtension
    {
        #region Public Methods

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

        #endregion Public Methods
    }
}