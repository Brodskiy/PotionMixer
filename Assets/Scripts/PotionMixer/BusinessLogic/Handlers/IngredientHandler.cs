using System.Collections.Generic;
using PotionMixer.Abstraction.Ingredient;
using PotionMixer.Data;

namespace PotionMixer.BusinessLogic.Handlers
{
    internal class IngredientHandler
    {
        public void SortIngredients(IEnumerable<IIngredient<IPreliminaryEffect>> ingredients, IDictionary<PreliminaryEffectGroup, List<IPreliminaryEffect>> sortedPreliminaryEffects)
        {
            foreach (var ingredient in ingredients)
            {
                CreateSortedEffects(ingredient, sortedPreliminaryEffects);
            }
        }

        private void CreateSortedEffects(IIngredient<IPreliminaryEffect> ingredient, IDictionary<PreliminaryEffectGroup, List<IPreliminaryEffect>> sortedPreliminaryEffects)
        {
            foreach (var effect in ingredient.GetPreliminaryEffects())
            {
                if (sortedPreliminaryEffects.TryGetValue(effect.EffectGroup, out var sortedEffect))
                {
                    sortedEffect.Add(effect);
                }
                else
                {
                    sortedPreliminaryEffects.Add(effect.EffectGroup, new List<IPreliminaryEffect>{effect});
                }
            }
        }
    }
}