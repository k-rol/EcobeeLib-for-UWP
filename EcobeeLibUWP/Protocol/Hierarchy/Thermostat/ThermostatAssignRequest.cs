﻿using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat
{
    [DataContract]
    public class ThermostatAssignRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/thermostat"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "assign".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "assign"; } }

        /// <summary>
        /// The set path the thermostats are being moved to.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// Comma separated list of thermostat identifiers.
        /// </summary>
        [DataMember(Name = "thermostats")]
        public string Thermostats { get; set; }
    }
}
