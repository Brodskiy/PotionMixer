using System.Collections.Generic;
using System.Linq;
using PotionMixer.Abstraction;
using PotionMixer.Abstraction.Ingredient;
using PotionMixer.BusinessLogic.Rules;
using PotionMixer.Data;
using UnityEngine;

namespace PotionMixer.BusinessLogic.Handlers
{
    internal class RuleHandler
    {
        private readonly Dictionary<PreliminaryEffectGroup, IRule> _rules = new()
        {
            [PreliminaryEffectGroup.Multiplier] = new MultiplierRule(),
            [PreliminaryEffectGroup.HealthIncrease] = new IncreaseRule(),
        };
        
        public void ApplyRules(Dictionary<PreliminaryEffectGroup, List<IPreliminaryEffect>> sortedPreliminaryEffects)
        {
            foreach (var effectGroup in sortedPreliminaryEffects.Keys)
            {
                if (_rules.TryGetValue(effectGroup, out var rule))
                {
                    sortedPreliminaryEffects[effectGroup] = rule.Apply(sortedPreliminaryEffects[effectGroup]).ToList();
                }
                else
                {
                    Debug.LogError($"Can`t found rule by effect group type {effectGroup}.");
                }
            }
        }
    }
}