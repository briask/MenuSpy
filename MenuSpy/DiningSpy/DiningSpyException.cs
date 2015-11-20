using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DiningSpy
{

    [Serializable]
    public class DiningSpyException : Exception
    {
        public DiningSpyException()
                : base()
        { }

        public DiningSpyException(string message)
                : base(message)
        { }

        public DiningSpyException(string format, params object[] args)
                : base(string.Format(format, args))
        { }

        public DiningSpyException(string message, Exception innerException)
                : base(message, innerException)
        { }

        public DiningSpyException(string format, Exception innerException, params object[] args)
                : base(string.Format(format, args), innerException)
        { }

        protected DiningSpyException(SerializationInfo info, StreamingContext context)
                : base(info, context)
        { }
    }
}
