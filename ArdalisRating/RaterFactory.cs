using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                        new object[] { engine, engine.Logger });
            }
            catch
            {
                return null;
            }
        }
    }
}
