using System.Collections.Generic;
using Mixer.Abstraction;

namespace PotionMixer.Abstraction.Potion
{
    public interface IPotion<out TResult> : IMixingResult
        where TResult : IPotionEffect
    {
        IEnumerable<TResult> GetEffects();
    }
}