﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirspeedIndicator
{
    public class PitotTube
    {
        float ramPressure = 0;
        float staticPressure = 50;

        public float getStaticAirPressure()
        {
            return staticPressure;
        }

        public float getRamAirPressure()
        {
            return ramPressure;
        }

        public void modifyStaticAirPressure(float pressure)
        {
            staticPressure = pressure;
        }

        public void modifyRamAirPressure(float pressure)
        {
            ramPressure = pressure;
        }
    }
}
