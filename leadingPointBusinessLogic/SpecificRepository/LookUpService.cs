using leadingPointDataClass.Context;
using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public class LookUpService: ILookUpService
    {
        LeadingPointContext context;
        public LookUpService(LeadingPointContext _context)
        {
            context = _context;
        }
        public List <Lookup> LoadGender()
        {
            return context.lookups.Where(g => g.lookUpCategory_ID == 1).ToList();
        }
        public List<Lookup> LoadPosition()
        {
            return context.lookups.Where(g => g.lookUpCategory_ID == 2).ToList();
        }
    }
}
