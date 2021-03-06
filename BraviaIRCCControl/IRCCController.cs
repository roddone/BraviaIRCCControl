﻿using BraviaIRCCControl.Extensions;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace BraviaIRCCControl
{
    /// <summary>
    /// IRCC Controller for Sony Bravia devices 
    /// </summary>
    public class IRCCController
    {
        #region Private Fields

        private const string _soapEnvelopeTemplate = "<?xml version=\"1.0\"?><s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\"><s:Body><u:X_SendIRCC xmlns:u=\"urn:schemas-sony-com:service:IRCC:1\"><IRCCCode>{0}</IRCCCode></u:X_SendIRCC></s:Body></s:Envelope>";
        private const string _urlTemplate = "http://{0}:{1}/sony/IRCC";

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Host name
        /// </summary>
        public string HostName { get; private set; }

        /// <summary>
        /// Pin Code
        /// </summary>
        public string PinCode { get; private set; }

        /// <summary>
        /// Port
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; private set; }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="port"></param>
        /// <param name="pinCode"></param>
        public IRCCController(string hostName, int port = 80, string pinCode = "0000")
        {
            this.HostName = hostName;
            this.Port = port;
            this.PinCode = pinCode;

            this.Url = string.Format(_urlTemplate, hostName, port);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Send an IRCC control code to the device
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<bool> Send(IRCCCodes code)
        {
            string parameters = string.Format(_soapEnvelopeTemplate, code.GetCode());
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(parameters);
            req.KeepAlive = true;
            req.Method = "POST";
            req.ContentType = "text/xml; charset=utf-8";
            req.ContentLength = bytes.Length;

            req.Headers.Add("SOAPAction", "\"urn:schemas-sony-com:service:IRCC:1#X_SendIRCC\"");
            req.Headers.Add("X-Auth-PSK", PinCode);

            try
            {
                bool isOK;
                using (Stream os = req.GetRequestStream())
                {
                    // Post data and close connection
                    os.Write(bytes, 0, bytes.Length);
                    using (HttpWebResponse resp = (await req.GetResponseAsync()) as HttpWebResponse)
                    {
                        isOK = resp.StatusCode == HttpStatusCode.OK;

                        //using (Stream respData = resp.GetResponseStream())
                        //{
                        //    using (StreamReader sr = new StreamReader(respData))
                        //    {
                        //        string response = sr.ReadToEnd();
                        //    }
                        //}
                    }
                }

                return isOK;
            }
            catch (Exception ex) {  }

            return false;
        }

        #endregion Public Methods
    }
}