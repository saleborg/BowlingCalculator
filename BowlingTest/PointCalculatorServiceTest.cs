using MongoTest.Models;
using MongoTest.Services;
using NUnit.Framework;
using System.Linq;



namespace BowlingTest
{
    public class PointCalculatorServiceTest
    {
        Series series;

        [SetUp]
        public void Setup()
        {
            series = new Series();
        }

        [Test]
        public void AddPointsTogheter()
        {
            series._throw.Add(new Throw(1, 1));
            var s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(2, s._throw.Last<Throw>()._sum);

        }

        [Test]
        public void AddAFullSeries()
        {
            series._throw.Add(new Throw(1, 1));
            var s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(2, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(4, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(6, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(8, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(10, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(12, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(14, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(16, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(18, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(20, s._throw.Last<Throw>()._sum);

        }

     
        public void ThreeStrikesTest()
        {
            series._throw.Add(new Throw(1, 5));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(4, 5));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(1, 1));
            series = new PointCalculatorService().AddPointsTogheter(series);


            Assert.AreEqual(80, series._throw.Last<Throw>()._sum);
        }

        [Test]
        public void PointTest()
        {
            series._throw.Add(new Throw(1, 1));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(1, 1));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(6, 3));
            series = new PointCalculatorService().AddPointsTogheter(series);



            Assert.AreEqual(32, series._throw.Last<Throw>()._sum);
        }



        [Test]
        public void AddAFullSeriesWithSpareInTheEnd()
        {
            series._throw.Add(new Throw(1, 1));
            var s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(2, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(4, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(6, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(8, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(10, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(12, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(14, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(16, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(18, s._throw.Last<Throw>()._sum);

            Throw t = new Throw(1, 9);
            t._throwThree = 1;
            series._throw.Add(t);
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(29, s._throw.Last<Throw>()._sum);

        }



        [Test]
        public void AddAFullSeriesWithStrikeInTheEnd()
        {
            series._throw.Add(new Throw(1, 1));
            var s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(2, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(4, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(6, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(8, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(10, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(12, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(14, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(16, s._throw.Last<Throw>()._sum);

            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(18, s._throw.Last<Throw>()._sum);

            Throw t = new Throw(10, 1);
            t._throwThree = 1;
            series._throw.Add(t);
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(30, s._throw.Last<Throw>()._sum);

        }


        [Test]
        public void AddPointsTogheter2Throws()
        {
            series._throw.Add(new Throw(1, 1));
            var s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(2, s._throw.Last<Throw>()._sum);
            series._throw.Add(new Throw(1, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(4, s._throw.Last<Throw>()._sum);


        }


        [Test]
        public void SparePointsTest()
        {


            series._throw.Add(new Throw(1, 9));
            series = new PointCalculatorService().AddPointsTogheter(series);
            series._throw.Add(new Throw(1, 7));
            series = new PointCalculatorService().AddPointsTogheter(series);
            var t = series._throw.First<Throw>();
            Assert.AreEqual(11, t._sum);
            t = series._throw.Last<Throw>();
            Assert.AreEqual(19, t._sum);
        }



        [Test]
        public void IfFirstThrowIsSpareAndSecoundStrikeTest()
        {
            series._throw.Add(new Throw(1, 9));
            series = new PointCalculatorService().AddPointsTogheter(series);
            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);
            var t = series._throw.First<Throw>();
            Assert.AreEqual(20, t._sum);
            t = series._throw.Last<Throw>();
            Assert.AreEqual(0, t._sum);
        }


        [Test]
        public void IfFirstThrowIsSpareAndSecoundStrikeAndThirdNormalTest()
        {
            series._throw.Add(new Throw(1, 9));
            series = new PointCalculatorService().AddPointsTogheter(series);
            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);
            series._throw.Add(new Throw(5, 3));
            series = new PointCalculatorService().AddPointsTogheter(series);
            var first = series._throw.First<Throw>();
            Assert.AreEqual(20, first._sum);

            var secund = series._throw.ElementAt<Throw>(1);
            Assert.AreEqual(38, secund._sum);

            var third = series._throw.Last<Throw>();
            Assert.AreEqual(46, third._sum);
        }



        [Test]
        public void StrikePointsTest()
        {

            series._throw.Add(new Throw(10, 0));
            series = new PointCalculatorService().AddPointsTogheter(series);
            series._throw.Add(new Throw(1, 7));
            series = new PointCalculatorService().AddPointsTogheter(series);
            var t = series._throw.First<Throw>();
            Assert.AreEqual(18, t._sum);
            t = series._throw.Last<Throw>();
            Assert.AreEqual(26, t._sum);
        }


       

        [Test]
        public void RandomPointTest2()
        {

            series._throw.Add(new Throw(1, 5));
            var s = new PointCalculatorService().AddPointsTogheter(series);

            series._throw.Add(new Throw(4, 5));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(3, 2));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(4, 6));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(10  , 0));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(9, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(8, 1));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(5, 4));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            series._throw.Add(new Throw(4, 6));
            s = new PointCalculatorService().AddPointsTogheter(series);
            
            Throw t = new Throw(5, 3);
            series._throw.Add(t);
            s = new PointCalculatorService().AddPointsTogheter(series);
            Assert.AreEqual(119, s._throw.Last<Throw>()._sum);
        }



       

    }

}

