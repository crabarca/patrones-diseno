using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Composite : IComposite
    {
        public List<IComposite> Composites { get; set; }
        
        public int Duration => Composites.Aggregate(0, (sum, task) => sum += task.Duration);

        public Composite(List<IComposite> composites)
        {
            Composites = composites;
        }
    }
}