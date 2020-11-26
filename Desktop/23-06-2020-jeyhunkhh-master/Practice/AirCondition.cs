using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    enum AirConditionMode
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    enum FanDirection
    {
        Top,
        Middle,
        Bottom
    }

    class AirCondition
    {
        public AirConditionMode Mode { get; set; }
        public FanDirection FanDirection { get; set; }
    }
}
