﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base() : Result
        public SuccessResult(string message) : base(true, message)
        { 
        

        }

        //mesaj vermek istemediğimizde bunu çalıştırıyoruz
        public SuccessResult() : base(true)
        {

        }
       
    }
}
