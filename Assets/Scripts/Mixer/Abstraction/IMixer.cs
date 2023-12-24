using System.Collections.Generic;

namespace Mixer.Abstraction
{
    public interface IMixer<in TMiscible, out TResult>
    where TMiscible : IMiscible
    where TResult : IMixingResult
    {
        TResult Mix(IEnumerable<TMiscible> ingredients);
    }
}