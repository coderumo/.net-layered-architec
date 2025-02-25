﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResults
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success) { Success = success; } //mesajsız başarı durumu gönderiliyor

        public bool Success { get; }
        public string Message { get; }
    }
}
