using leadingPointDataAccess.generic;
using leadingPointDataClass.Context;
using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public class CityService:ICityService
    {
        Igeneric<City> generic;
        LeadingPointContext context;
        public CityService(Igeneric<City> _generic,LeadingPointContext _contex)
        {
            generic = _generic;
            context = _contex;
        }
        public List<City> LoadALl()
        {
            return generic.LoadAll();
        }
        public List<City> LoadByCountryId(int country_id)
        {
            return context.cities.Where(c => c.Country_Id == country_id).ToList();
        }
    }
}
