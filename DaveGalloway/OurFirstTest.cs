﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fit;

namespace DaveGalloway
{
    public class OurFirstTest : fit.ColumnFixture
    {
        public string string1;
        public string string2;
        public string Concatenate()
        {
            return string1 + " " + string2;
        }
    }
}