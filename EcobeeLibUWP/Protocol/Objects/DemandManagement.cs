﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class DemandManagement
    {
        public DemandManagement()
        {
            TempOffsets = new List<int>();
        }

        /// <summary>
        /// The date(UTC) for the beginning of this day's demand management series.
        /// </summary>
        [DataMember(Name = "date")]
        public string Date { get; set; }

        /// <summary>
        /// The hour in the day this series begins at.Range: 0-23
        /// </summary>
        [DataMember(Name = "hour")]
        public int Hour { get; set; }

        /// <summary>
        /// The series of 12, 5 minute interval temperature adjustments in the hour. 
        /// Valid integer values are required for each interval. See Temperature values.
        /// </summary>
        [DataMember(Name = "tempOffsets")]
        public IList<int> TempOffsets { get; set; }
    }
}