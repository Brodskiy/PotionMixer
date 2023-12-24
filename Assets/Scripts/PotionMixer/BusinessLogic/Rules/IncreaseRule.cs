using System.Collections.Generic;
using PotionMixer.Abstraction;
using PotionMixer.Abstraction.Ingredient;

namespace PotionMixer.BusinessLogic.Rules
{
    internal class IncreaseRule : IRule
    {
        public IEnumerable<IPreliminaryEffect> Apply(IEnumerable<IPreliminaryEffect> preliminaryEffect)
        {
            //TODO add apply logic.
            return preliminaryEffect;
        }
    }
}