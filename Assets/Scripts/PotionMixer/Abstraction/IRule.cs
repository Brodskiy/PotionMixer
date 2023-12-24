using System.Collections.Generic;
using PotionMixer.Abstraction.Ingredient;

namespace PotionMixer.Abstraction
{
    internal interface IRule
    {
        IEnumerable<IPreliminaryEffect> Apply(IEnumerable<IPreliminaryEffect> preliminaryEffect);
    }
}