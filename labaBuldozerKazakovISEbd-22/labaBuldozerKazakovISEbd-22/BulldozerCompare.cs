﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace labaBuldozerKazakovISEbd_22
{
    public class BulldozerCompare : IComparer<VehicleBuldozer>
    {
        public int Compare(VehicleBuldozer x, VehicleBuldozer y)
        {
            if (x is ModBuldozer && y is ModBuldozer)
            {
                return ComparerModBuldozer((ModBuldozer)x, (ModBuldozer)y);
            }
            if (x is ModBuldozer && y is VehicleBuldozer)
            {
                return -1;
            }
            if (x is VehicleBuldozer && y is ModBuldozer)
            {
                return 1;
            }
            if (x is VehicleBuldozer && y is VehicleBuldozer)
            {
                return ComparerBuldozer((BuldozerBase)x, (BuldozerBase)y);
            }
            return 0;
        }
        private int ComparerBuldozer(BuldozerBase x, BuldozerBase y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerModBuldozer(ModBuldozer x, ModBuldozer y)
        {
            var res = ComparerBuldozer(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.BackSpoiler != y.BackSpoiler)
            {
                return x.BackSpoiler.CompareTo(y.BackSpoiler);
            }
            if (x.Bucket != y.Bucket)
            {
                return x.Bucket.CompareTo(y.Bucket);
            }
            return 0;
        }
    }
}