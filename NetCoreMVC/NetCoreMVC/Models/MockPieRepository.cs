using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies() {
            _pies = new List<Pie>
            {
                new Pie { Id=1,Name="Apple Pie",Price = 18.50M, Description= "Apple Pie", LongDescription ="Apppleee Pie",IsPieOfTheWeek= true},
                new Pie { Id=2,Name="Apple Pie",Price = 18.50M, Description= "Apple Pie", LongDescription ="Apppleee Pie",IsPieOfTheWeek= true}
            };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetByPieId(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
