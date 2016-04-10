﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp.Helpers
{
    public static class Convertor
    {
        public double ToMilivolts(int readADC)
        {
            return Convert.ToDouble(readADC) * (3300.0 / 1024);
        }
        public string ToDegrees(double milivolts , string typeofTemperature)
        {
            if (typeofTemperature== "Celsius" )
            {
                return ((milivolts - 100.00) / 10.0) - 40.0;
            }
        }

    }
}