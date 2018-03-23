﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BraviaIRCCControl
{
    public class IRCCController
    {
        public IRCCController(string hostName, int port = 80)
        {
            this.HostName = hostName;
            this.Port = port;
        }

        public string HostName { get; private set; }
        public int Port { get; private set; }

        public async Task Send(IRCCCodes code)
        {
            string response = "";
            StringBuilder body = new StringBuilder("<?xml version=\"1.0\"?>");
            body.Append("<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">");
            body.Append("<s:Body>");
            body.Append("<u:X_SendIRCC xmlns:u=\"urn:schemas-sony-com:service:IRCC:1\">");
            body.Append("<IRCCCode>" + code.GetCode() + "</IRCCCode>");
            body.Append("</u:X_SendIRCC>");
            body.Append("</s:Body>");
            body.Append("</s:Envelope>");
            
            string Url = $"http://{HostName}:{Port}/IRCC";
            string Parameters = body.ToString();
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Parameters);
            req.KeepAlive = true;
            req.Method = "POST";
            req.ContentType = "text/xml; charset=utf-8";
            req.ContentLength = bytes.Length;

            req.Headers.Add("SOAPAction", "\"urn:schemas-sony-com:service:IRCC:1#X_SendIRCC\"");
            req.Headers.Add("X-Auth-PSK", "0000");

            try
            {
                System.IO.Stream os = req.GetRequestStream();
                // Post data and close connection
                os.Write(bytes, 0, bytes.Length);
                System.Net.HttpWebResponse resp = (await req.GetResponseAsync()) as HttpWebResponse;

                bool isOK = resp.StatusCode == HttpStatusCode.OK;

                Stream respData = resp.GetResponseStream();
                StreamReader sr = new StreamReader(respData);
                response = sr.ReadToEnd();
                os.Close();
                sr.Close();
                respData.Close();
                if (response != "")
                {
                    await Task.Delay(1000);
                }
                else
                {
                }
            }
            catch
            {
            }
        }
    }
}
