using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public interface ILookUpService
    {
        List<Lookup> LoadGender();
        List<Lookup> LoadPosition();
    }
}
