using leadingPointDataAccess.generic;
using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public class CountryService:ICountryService
    {
        Igeneric<Country> generic;
        public CountryService(Igeneric<Country>_generic)
        {
            generic = _generic;
        }
        public List<Country> LoadCountry()
        {
            return generic.LoadAll().ToList();
        }
    }
}
