using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassBookServer.Models
{
    public class SerialNumbers
    {
        public string lastUpdated { get; set; }

        public IList<string> serialNumbers { get; set; }
    }
}