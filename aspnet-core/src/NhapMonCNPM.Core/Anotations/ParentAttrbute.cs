﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NhapMonCNPM.Anotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ParentAttrbute : Attribute
    {
        public Type ParentType { get; set; }
    }
}
