using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Octoio.Fey.Data.Dto;
using Octoio.Fey.Utils;

namespace Octoio.Fey.Data.Mapper
{

    public class SkillEffectTargetMechanicConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(SkillEffectTargetMechanic).IsAssignableFrom(objectType);
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
            var enumType = EEnum.Parse<Type.SkillEffectTargetMechanicType>(type);
            var target = enumType switch
            {
                Type.SkillEffectTargetMechanicType.Self => new SkillEffectTargetMechanicSelf(),
                Type.SkillEffectTargetMechanicType.Team => new SkillEffectTargetMechanicTeam(),
                Type.SkillEffectTargetMechanicType.Selected => new SkillEffectTargetMechanicSelected(),
                Type.SkillEffectTargetMechanicType.Circle => new SkillEffectTargetMechanicCircle(),
                Type.SkillEffectTargetMechanicType.Rectangle => new SkillEffectTargetMechanicRectangle(),
                _ => null as SkillEffectTargetMechanic
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
