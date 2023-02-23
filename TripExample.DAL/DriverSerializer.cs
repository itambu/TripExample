using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripExample.DataModel;

namespace TripExample.DAL
{
    public class DriverSerializer<T>
    {
        protected abstract T CreateInstance(string s);
        protected abstract void Instance(T instance);
    }
}
