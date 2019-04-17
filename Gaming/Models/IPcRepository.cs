using System.Collections.Generic;

namespace Gaming.Models
{
    public interface IPcRepository
    {
        IEnumerable<Pc> GetAllPces();
        Pc GetPcById(int pcId);
    }
}
