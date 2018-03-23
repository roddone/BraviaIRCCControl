using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace BraviaIRCCControl
{
    public class IRCCCodeAttribute : Attribute
    {
        public IRCCCodeAttribute(string code)
        {
            this.Code = code;
        }

        public string Code { get; private set; }
    }

    public static class IRCCCodesExtension
    {
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
    }
}
