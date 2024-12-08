using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResults<T> : DataResults<T> //error duurmunda data gönderimi de yapabilmek için
    {
        public ErrorDataResults(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResults(T data) : base(data, false)
        {
        }

        public ErrorDataResults(string message) : base(default, false, message)
        {
        }

        public ErrorDataResults() : base(default, false)
        {

        }
    }
}
