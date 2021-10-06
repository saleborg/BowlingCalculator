using MongoTest.Models;
using System.Linq;

namespace MongoTest.Services
{
    public class PointCalculatorService
    {
        public Series AddPointsTogheter(Series series)
        {
            Throw t = series._throw.Last<Throw>();
            int ndToLastThrowSum = 0;
            int throws = series._throw.Count;
            if (throws > 1)
            {
                ndToLastThrowSum = HandleIfNotFirstThrow(series, t, throws);
            }

            if (IsThrowAStrike(t))
            {
                series._throw.Last<Throw>()._sum = 0;
            }
            else
            {
                series._throw.Last<Throw>()._sum = t._throwOne + t._throwTwo + ndToLastThrowSum;
            }

            if (IsLastThrow(t))
            {
                HandleLastThrow(series, t, ndToLastThrowSum);
            }

            return series;
        }

        private int HandleIfNotFirstThrow(Series series, Throw t, int throws)
        {
            int ndToLastThrowSum;
            Throw ndToLastThrow = series._throw[series._throw.Count - 2];
            if (IsThrowAStrike(ndToLastThrow))
            {
                HandleStrike(series, t, throws, ndToLastThrow);

            }
            else if (IsThrowASpare(ndToLastThrow))
            {

                var thridToLastThrow = 0;
                if (throws > 2)
                {
                    thridToLastThrow = series._throw[series._throw.Count - 3]._sum;
                }
                ndToLastThrow._sum = 10 + t._throwOne + thridToLastThrow;
            }
            ndToLastThrowSum = ndToLastThrow._sum;
            return ndToLastThrowSum;
        }

        private void HandleStrike(Series series, Throw t, int throws, Throw ndToLastThrow)
        {
            var totSumSoFar = 0;
           

            if (throws > 2)
            {
                totSumSoFar = series._throw[series._throw.Count - 3]._sum;
            }
            
            ndToLastThrow._sum = 10 + t._throwOne + t._throwTwo + totSumSoFar;
        }

        private void HandleLastThrow(Series series, Throw t, int ndToLastThrowSum)
        {
            if (IsThrowAStrike(t))
            {
                series._throw.Last<Throw>()._sum += 10 + t._throwTwo + t._throwThree + ndToLastThrowSum;

            }
            else
            {
                series._throw.Last<Throw>()._sum += t._throwThree;
            }
        }

        private bool IsThrowASpare(Throw t) => t._throwOne + t._throwTwo == 10;

        private bool IsThrowAStrike(Throw t) => t._throwOne == 10;

        private bool IsLastThrow(Throw t) => t._throwThree != -1;
    }
}
