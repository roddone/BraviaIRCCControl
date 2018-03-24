using System;

namespace BraviaIRCCControl
{
    internal class IRCCCodeAttribute : Attribute
    {
        #region Public Properties

        public string Code { get; private set; }

        #endregion Public Properties

        #region Public Constructors

        public IRCCCodeAttribute(string code)
        {
            this.Code = code;
        }

        #endregion Public Constructors
    }
}