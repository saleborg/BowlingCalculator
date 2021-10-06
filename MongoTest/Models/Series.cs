using System.Collections.Generic;

namespace MongoTest.Models
{
    public class Series
    {
        public int Id { get; set; }
        public List<Throw> _throw;


        public Series()
        {
            _throw = new List<Throw>();
        }



    }
}
