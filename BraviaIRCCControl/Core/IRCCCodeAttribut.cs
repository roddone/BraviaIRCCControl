using System;

namespace BraviaIRCCControl.Core
{
    /// <summary>
    /// IRCC Code attribute
    /// </summary>
    internal class IRCCCodeAttribute : Attribute
    {
        #region Public Properties

        /// <summary>
        /// Code value
        /// </summary>
        public string Code { get; private set; }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        public IRCCCodeAttribute(string code)
        {
            this.Code = code;
        }

        #endregion Public Constructors
    }
}