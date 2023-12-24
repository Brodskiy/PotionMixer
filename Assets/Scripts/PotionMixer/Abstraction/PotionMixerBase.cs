using System.Collections.Generic;
using Mixer.Abstraction;
using PotionMixer.Abstraction.Ingredient;
using PotionMixer.Abstraction.Potion;
using PotionMixer.Data;

namespace PotionMixer.Abstraction
{
    public abstract class PotionMixerBase : IMixer<IIngredient<IPreliminaryEffect>,IPotion<IPotionEffect>>
    {
        internal abstract Dictionary<PreliminaryEffectGroup, IRule> Rules { get; }
        
        public abstract IPotion<IPotionEffect> Mix(IEnumerable<IIngredient<IPreliminaryEffect>> ingredients);
    }
}