using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Exceptions
{
    public class RecordNotFoundExcepiton:Exception
    {
        public string Message { get; set; }
        public RecordNotFoundExcepiton(string message):base(message)
        {
            this.Message = message;
        }
    }
}
