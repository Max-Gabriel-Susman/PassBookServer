using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassBookServer
{
    public class ApplePassServiceData
    {

        /*
         * Apple Wallet post payload is a JSON dictionary containing a single key and value: pushToken
        **/
        public class DevicesPayload
        {
            public string pushToken { get; set; }
        }
        /*
        *  If there are matching passes, returns HTTP status 200 with a JSON dictionary with the following keys and values
        */
        public class SerialNumbers
        {
            public string lastUpdated { get; set; }
            public List<string> serialNumbers { get; set; }
        }
        public class LogPayload
        {
            public string[] logs { get; set; }
        }
    }
}