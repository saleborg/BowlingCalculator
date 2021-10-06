namespace MongoTest.Models
{
    public class Throw
    {
        public int _throwOne;
        public int _throwTwo;
        public int _throwThree = -1;
        public int _sum;

        public Throw(int throwOne, int throwTwo)
        {
            _throwOne = throwOne;
            _throwTwo = throwTwo;

        }
    }
}
