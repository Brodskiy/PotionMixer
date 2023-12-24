using System.Collections.Generic;
using Mixer.Abstraction;

namespace PotionMixer.Abstraction.Ingredient
{
    public interface IIngredient<out TEffect> : IMiscible
        where TEffect : IPreliminaryEffect
    {
        IEnumerable<TEffect> GetPreliminaryEffects();
    }
}
