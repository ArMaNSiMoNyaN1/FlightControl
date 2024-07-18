using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace FlightControl.User;

[JsonConverter(typeof(StringEnumConverter))]
public enum Role
{
    Admin,
    Pilot,
    Dispatcher,
    Technician,
    GroundStaff
}