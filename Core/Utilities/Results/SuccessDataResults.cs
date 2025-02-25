﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResults<T> : DataResults<T> //Succes durumunda data gönderebilmek için
    {
        public SuccessDataResults(T data, string message) : base(data, true, message)
        {
        }
        public SuccessDataResults(T data) : base(data, true)
        {
        }

        public SuccessDataResults(string message) : base(default, true, message) 
        { 
        }

        public SuccessDataResults() : base(default, true) 
        { 
        }
    }
}
