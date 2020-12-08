using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_KpIEp_Laba_13._1
{
    class PchelException: Exception
    {
        public PchelException(string message): base(message)
        { }
    }
}
