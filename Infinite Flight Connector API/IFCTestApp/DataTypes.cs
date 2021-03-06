﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fds.IFAPI
{
    [DataContract]
    public enum APIResult
    {
        [EnumMember]
        OK,
        [EnumMember]
        Error
    }

    [DataContract(Namespace = "")]
    [KnownType(typeof(APIAircraftState))]
    public class APIResponse
    {
        [DataMember]
        public APIResult Result { get; set; }
        [DataMember]
        public string Type { get; set; }

        public APIResponse()
        {
            Type = this.GetType().ToString();
        }
    }

    [DataContract]
    public class GetValueResponse : APIResponse
    {
        [DataMember]
        public CallParameter[] Parameters { get; set; }
    }

    public class Coordinate
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    [DataContract(Namespace = "")]
    public class CallParameter
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
    }

    [DataContract(Namespace = "")]
    public class APICall
    {
        [DataMember]
        public string Command { get; set; }

        [DataMember]
        public CallParameter[] Parameters { get; set; }
    }

    [DataContract]
    public enum GearState
    {
        [EnumMember]
        Unknown,
        [EnumMember]
        Down,
        [EnumMember]
        Up,
        [EnumMember]
        Moving,
        [EnumMember]
        MovingDown,
        [EnumMember]
        MovingUp
    }

    [DataContract]
    public enum SpoilersPosition
    {
        [EnumMember]
        Retracted,
        [EnumMember]
        Flight,
        [EnumMember]
        Full
    }

    [DataContract(Namespace = "")]
    public class APIAircraftState : APIResponse
    {
        [DataMember]
        public float AltitudeAGL { get; set; }
        [DataMember]
        public float AltitudeMSL { get; set; }
        [DataMember]
        public float Bank { get; set; }
        [DataMember]
        public float CourseTrue { get; set; }
        [DataMember]
        public GearState GearState { get; set; }
        [DataMember]
        public float GForce { get; set; }
        [DataMember]
        public float GroundSpeed { get; set; }
        [DataMember]
        public float GroundSpeedKts { get; set; }
        [DataMember]
        public float HeadingMagnetic { get; set; }
        [DataMember]
        public float HeadingTrue { get; set; }
        [DataMember]
        public float IndicatedAirspeed { get; set; }
        [DataMember]
        public float IndicatedAirspeedKts { get; set; }
        [DataMember]
        public bool IsAutopilotOn { get; set; }
        [DataMember]
        public bool IsCrashed { get; set; }
        [DataMember]
        public bool IsLanded { get; set; }
        [DataMember]
        public bool IsOnGround { get; set; }
        [DataMember]
        public bool IsOverLandingWeight { get; set; }
        [DataMember]
        public bool IsOverTakeoffWeight { get; set; }
        [DataMember]
        public bool IsPushbackActive { get; set; }
        [DataMember]
        public Coordinate Location { get; set; }
        [DataMember]
        public float MachNumber { get; set; }
        [DataMember]
        public float MagneticDeviation { get; set; }
        [DataMember]
        public float Pitch { get; set; }
        [DataMember]
        public bool ReverseThrustState { get; set; }
        [DataMember]
        public float SideForce { get; set; }
        [DataMember]
        public SpoilersPosition SpoilersPosition { get; set; }
        [DataMember]
        public bool Stalling { get; set; }
        [DataMember]
        public float StallProximity { get; set; }
        [DataMember]
        public bool StallWarning { get; set; }
        [DataMember]
        public float TrueAirspeed { get; set; }
        [DataMember]
        public float Velocity { get; set; }
        [DataMember]
        public float VerticalSpeed { get; set; }
        [DataMember]
        public float Weight { get; set; }
        [DataMember]
        public float WeightPercentage { get; set; }
    }

}
