using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B2G
{
    public class B2GException : ApplicationException
    {
        private AckReturnCode returnCode;
        public AckReturnCode ReturnCode { get { return returnCode; } }
        public B2GException(AckReturnCode returnCode)
            : base("B2G Error")
        {
            this.returnCode = returnCode;
        }
        public B2GException(AckReturnCode returnCode, Exception ex)
            : base("B2G Error", ex)
        {
            this.returnCode = returnCode;
        }
        public B2GException(string errorMessage, AckReturnCode returnCode)
            : base(errorMessage)
        {
            this.returnCode = returnCode;
        }
        public B2GException(string errorMessage, AckReturnCode returnCode, Exception ex)
            : base(errorMessage, ex)
        {
            this.returnCode = returnCode;
        }
    }
}
