using System.Collections.Generic;
using Mixer.Abstraction;
using PotionMixer.Abstraction.Ingredient;
using PotionMixer.Abstraction.Potion;
using PotionMixer.BusinessLogic.Handlers;
using PotionMixer.Data;

namespace PotionMixer.BusinessLogic
{
    public class PotionMixer : IMixer<IIngredient<IPreliminaryEffect>,IPotion<IPotionEffect>>
    {
        private readonly RuleHandler _ruleHandler;
        private readonly IngredientHandler _ingredientHandler;
        
        private Dictionary<PreliminaryEffectGroup, List<IPreliminaryEffect>> _sortedPreliminaryEffects;

        public PotionMixer()
        {
            _ruleHandler = new RuleHandler();
            _ingredientHandler = new IngredientHandler();
        }

        public IPotion<IPotionEffect> Mix(IEnumerable<IIngredient<IPreliminaryEffect>> ingredients)
        {
            _sortedPreliminaryEffects = new Dictionary<PreliminaryEffectGroup, List<IPreliminaryEffect>>();
            _ingredientHandler.SortIngredients(ingredients, _sortedPreliminaryEffects);
            _ruleHandler.ApplyRules(_sortedPreliminaryEffects);
            //TODO add logic for creating a mixing result
            return null;
        }
    }
}