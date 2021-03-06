﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class PetrolTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;

            if(emissions >= 1 && emissions < 51)
            {
                return 10;
            }
            else if (emissions > 255)
            {
                return 2070;
            }
            else if (emissions > 226)
            {
                return 1760;
            }
            else if (emissions >191)
            {
                return 1240;
            }
            else if (emissions > 171)
            {
                return 830;
            }
            else if (emissions > 151)
            {
                return 515;
            }
            else if (emissions > 131)
            {
                return 205;
            }
            else if (emissions > 111)
            {
                return 165;
            }
            else if (emissions > 101)
            {
                return 145;
            }
            else if (emissions > 91)
            {
                return 125;
            }
            else if (emissions > 76)
            {
                return 105;
            }
            else if (emissions > 51)
            {
                return 25;
            }
            else if (emissions > 1)
            {
                return 10;
            }
            else
            {
                return 0;
            }            
        }
    }
}
