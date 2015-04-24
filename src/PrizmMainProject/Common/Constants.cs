﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public class Constants
    {
        public const int StatusNotifyHistorySize = 400;
        public const float WallThicknessPrecision = 0.01f;
        public const int MinYear = 1950;
        public const int MaxYear = 2150;
        public const int DiameterDiffLimit = 2;
        public const int ThicknessDiffLimit = 2;

        public const string PositiveDigitMask = "\\d+";

        /// <summary>
        /// Minimal length which can be cut from pipe, in millimeters
        /// </summary>
        public const int MinSpoolCut = 20;

        /// <summary>
        /// period in percents for remaining about execution of control operation
        /// </summary>
        public const float PercentForInspectionOperation = 0.90f;

        /// <summary>
        /// Warning should be shown this amount of days before expiration
        /// </summary>
        public const int DaysToExpirationWarning = 30;

        /// <summary>
        /// Number of digits before the decimal point
        /// </summary>
        public const int DigitsBeforeDecimalPoint = 6;

        /// <summary>
        /// Max value for Latitude
        /// </summary>
        public const int MaxLatitude = 90;

        /// <summary>
        /// Max value for Longitude
        /// </summary>
        public const int MaxLongitude = 180;
    }
}
