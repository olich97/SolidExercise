using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public abstract class Rater
    {
        protected readonly RatingEngine _engine;
        protected readonly ConsoleLogger _logger;
        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public abstract void Rate(Policy policy);
    }
}
