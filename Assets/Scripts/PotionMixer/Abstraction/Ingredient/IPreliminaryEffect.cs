using PotionMixer.Data;

namespace PotionMixer.Abstraction.Ingredient
{
    public interface IPreliminaryEffect
    {
        PreliminaryEffectGroup EffectGroup { get; }
    }
}