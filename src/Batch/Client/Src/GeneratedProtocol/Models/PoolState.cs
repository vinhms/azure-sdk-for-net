// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for PoolState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PoolState
    {
        [System.Runtime.Serialization.EnumMember(Value = "active")]
        Active,
        [System.Runtime.Serialization.EnumMember(Value = "deleting")]
        Deleting,
        [System.Runtime.Serialization.EnumMember(Value = "upgrading")]
        Upgrading
    }
}
