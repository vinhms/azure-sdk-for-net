// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for PoolLifetimeOption.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PoolLifetimeOption
    {
        [System.Runtime.Serialization.EnumMember(Value = "jobschedule")]
        Jobschedule,
        [System.Runtime.Serialization.EnumMember(Value = "job")]
        Job,
        [System.Runtime.Serialization.EnumMember(Value = "unmapped")]
        Unmapped
    }
}
