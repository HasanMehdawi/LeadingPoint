using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public interface ICityService
    {
        List<City> LoadALl();
        List<City> LoadByCountryId(int country_id);
    }
}
