using Microsoft.Extensions.Options;
using TripExample.DAL;
using TripExample.DataModel;

namespace TripExample.BL
{
    public class DriverController
    {
        private IRepository<Driver>? _repository;

        public DriverController(IRepository<Driver>? repository)
        {
            _repository = repository;
        }

        public DriverController() : this(null)
        {
        }

        public void Add(Driver driver)
        {
            Validate(driver);
            _repository!.Add(driver);
            _repository.Save();
        }

        private void Validate(Driver driver)
        {
            throw new NotImplementedException();
        }

        public void Remove(int driverId) 
        {
            var temp = _repository!.Get().OrderBy(x=>x.StartDate)  Where(d => d.Id == driverId).FirstOrDefault();
            if (temp is not null)
            {

            }
            else 
            {
                throw new InvalidOperationException();
            }

            if (temp!.Trips!.Count() > 0)
            {
                throw new InvalidOperationException("Driver has provided some trips");
            }
            _repository!.Delete(temp);
            _repository.Save();
        }
    }
}