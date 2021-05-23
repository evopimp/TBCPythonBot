﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SharedLib
{
    public class WorldMapArea
    {
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; } = string.Empty;
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public int UIMapId { get; set; }
        public string Continent { get; set; } = string.Empty;


        public float ToWorldX(float value)
        {
            return ((LocBottom - LocTop) * value / 100) + LocTop;
        }

        public float ToWorldY(float value)
        {
            return ((LocRight - LocLeft) * value / 100) + LocLeft;
        }

        public float ToMapX(float value)
        {
            return 100 - (((value - LocBottom) * 100) / (LocTop - LocBottom));
        }

        public float ToMapY(float value)
        {
            return 100 - (((value - LocRight) * 100) / (LocLeft - LocRight));
        }

    }
}
