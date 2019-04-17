using System.Collections.Generic;
using System.Linq;

namespace Gaming.Models
{
    public class MockPcReposetory : IPcRepository
    {
        private List<Pc> _pces;

        public MockPcReposetory()
        {
            if (_pces == null )
            {
                InitializePces();

            }

        }

        private void InitializePces()
        {
            _pces = new List<Pc>
            {
                new Pc{Id = 0, Name ="Intel", Price = 12000, ShortDescription = "Fast Gaming Computer", LongDescription ="Computer Details", Quantity = 5},
                new Pc{Id = 0, Name ="AMD", Price = 8000, ShortDescription = "Fast Gaming Computer", LongDescription ="Computer Details", Quantity = 2}
            };
        }

        public IEnumerable<Pc> GetAllPces()
        {
            return _pces;
        }

        public Pc GetPcById(int pcId)
        {
            return _pces.FirstOrDefault(p => p.Id == pcId);
        }
    }
}
