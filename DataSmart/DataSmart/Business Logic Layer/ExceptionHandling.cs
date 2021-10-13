using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSmart.Business_Logic_Layer
{
    class ExceptionHandling : Exception
    {
        public ExceptionHandling(string Message) : base(Message)
        {

        }
    }
}
