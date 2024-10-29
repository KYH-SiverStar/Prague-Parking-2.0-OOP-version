// Json converter for Vehicle polymorphism
using System.Text.Json.Serialization;
using System.Text.Json;

public class VehicleConverter : JsonConverter<Vehicle>
{
    public override Vehicle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            var registrationNumber = root.GetProperty("RegistrationNumber").GetString();
            var type = root.GetProperty("Type").GetString();

            return type switch
            {
                "Car" => new Car(registrationNumber),
                "MC" => new MC(registrationNumber),
                _ => throw new NotSupportedException($"Unsupported vehicle type: {type}")
            };
        }
    }

    public override void Write(Utf8JsonWriter writer, Vehicle value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("RegistrationNumber", value.RegistrationNumber);
        writer.WriteString("Type", value.GetType().Name);
        writer.WriteString("ArrivalTime", value.ArrivalTime.ToString("o"));
        writer.WriteEndObject();
    }
}