using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Octoio.Fey.Data.Dto;
using Octoio.Fey.Utils;

namespace Octoio.Fey.Data.Mapper
{

    public class SkillActionNodeConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(SkillActionNode).IsAssignableFrom(objectType);
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
            var enumType = EEnum.Parse<Type.SkillActionNode>(type);
            var target = enumType switch
            {
                Type.SkillActionNode.Sequence => new SkillActionSequenceNode(),
                Type.SkillActionNode.Parallel => new SkillActionParallelNode(),
                Type.SkillActionNode.Delay => new SkillActionDelayNode(),
                Type.SkillActionNode.Animation => new SkillActionAnimationNode(),
                Type.SkillActionNode.Sound => new SkillActionSoundNode(),
                Type.SkillActionNode.Hit => new SkillActionHitEffectNode(),
                Type.SkillActionNode.Status => new SkillActionStatusEffectNode(),
                Type.SkillActionNode.Summon => new SkillActionSummonNode(),
                Type.SkillActionNode.Requirement => new SkillActionRequirementNode(),
                _ => null as SkillActionNode
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
