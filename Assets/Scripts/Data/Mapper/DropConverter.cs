using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Octoio.Fey.Data.Dto;
using Octoio.Fey.Utils;

namespace Octoio.Fey.Data.Mapper
{

    public class DropConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(Drop).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load the JSON into a JObject for inspection.
            JObject jo = JObject.Load(reader);
            var type = jo["type"]?.ToString();
            if (type == null)
            {
                throw new JsonSerializationException("Missing 'type' property.");
            }
            var enumType = EEnum.Parse<Type.Drop>(type);
            var target = enumType switch
            {
                Type.Drop.Gold => new GoldDrop(),
                Type.Drop.Equipment => new EquipmentDrop(),
                Type.Drop.Weapon => new WeaponDrop(),
                Type.Drop.Skill => new SkillDrop(),
                _ => null as Drop
            }
             ?? throw new JsonSerializationException($"Unknown node type: {type}");

            // Populate the target with the JSON properties.
            serializer.Populate(jo.CreateReader(), target);
            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // For serialization, you can usually defer to the default serializer.
            serializer.Serialize(writer, value);
        }
    }

}
