using FacadePattern.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class LibraryFacade
    {
        public void DoWhatNeeded() 
        {
            new SubSystemX().DoX();
            new SubSystemY().DoY();
            new SubSystemZ().DoZ();
            new SubSystemA().DoA();
            new SubSystemZ().DoZ();
            new SubSystemY().DoY();
            new SubSystemX().DoX();
        }
    }
}
