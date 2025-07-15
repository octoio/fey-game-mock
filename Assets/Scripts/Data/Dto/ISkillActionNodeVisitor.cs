using System;

namespace Octoio.Fey.Data.Dto
{
    public interface ISkillActionNodeVisitor<TResult>
    {
        TResult Visit(Dto.SkillActionSequenceNode skillActionSequenceNode);
        TResult Visit(Dto.SkillActionParallelNode skillActionParallelNode);
        TResult Visit(Dto.SkillActionDelayNode skillActionDelayNode);
        TResult Visit(Dto.SkillActionAnimationNode skillActionAnimationNode);
        TResult Visit(Dto.SkillActionSoundNode skillActionSoundNode);
        TResult Visit(Dto.SkillActionHitEffectNode skillActionHitEffectNode);
        TResult Visit(Dto.SkillActionStatusEffectNode skillActionStatusEffectNode);
        TResult Visit(Dto.SkillActionSummonNode skillActionSummonNode);
        TResult Visit(Dto.SkillActionRequirementNode skillActionRequirementNode);
    }
}
