using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class GpsPosConverter
    {
        // 赤道半径 Equator radius(メートル)
        public const double EQUATOR_RADIUS = 6378137;
        // 極半径 Polar radius(メートル)
        public const double POLAR_RADIUS = 6356752;

        // (GpsPosData)aから(GpsPosData)bへの移動距離を返します。
        // x : 北方向への移動距離（南に移動したらマイナス）
        // y : 東方向への移動距離（西に移動したらマイナス）
        // x : 上方向への移動距離（下に移動したらマイナス）
        public static Vector3 GetDistance(GpsPosData a, GpsPosData b)
        {
            double x, y, z;
            x = y = z = 0;
            // 緯度方向の計算
            // 緯度1度あたりの長さ＝極半径×2×π÷360
            x = (b.Latitude - a.Latitude) * (POLAR_RADIUS * 2.0 * Math.PI / 360.0);
            // 経度方向の計算
            // 経度1度あたりの長さ＝cos(緯度÷180×π)×赤道半径×2×π÷360
            y = (b.Longitude - a.Longitude) * (Math.Cos(b.Latitude / 180 * Math.PI) * EQUATOR_RADIUS * 2.0 * Math.PI / 360.0);
            // 標高の計算
            z = (b.Height - a.Height);
            return new Vector3((float)x, (float)y, (float)z);
        }
    }
}
