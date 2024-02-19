using System;
using System.Collections.Generic;
using System.Text;

namespace SDKAPI
{
    public class APIException : Exception
    {
        public APIException(string message) : base(message) { }

        public object ContentData { get; internal set; }

        public int Code { get; internal set; }

        public string URL { get; internal set; }
    }
}
