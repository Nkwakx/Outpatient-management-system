﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OCMS03.Extensions
{
    public class MyBirthDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dt = (DateTime)value;
            if (dt.Date.CompareTo(DateTime.Now) < 0)
                return true;
            else
                return false;
        }
    }
}
