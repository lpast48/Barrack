using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class RecruitmentException : Exception
    {
        public RecruitmentException(string message = "")
            : base(message) { }
    }
}
