using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public static class BLFActory
   {
   public static IBL GetBL()
      {
         return new BL.BLImp1();
      }
   }
}
