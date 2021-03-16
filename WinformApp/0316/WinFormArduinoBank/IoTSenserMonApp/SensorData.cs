using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTSenserMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }
        public int Value { get; set; }
        public bool simulFlag { get; set; }

        public SensorData(DateTime current, int value, bool simulFlag)
        {
            Current = current;
            Value = value;
            this.simulFlag = simulFlag;
        }
    }

    
}
