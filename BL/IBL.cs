﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BL
{
   public interface IBL
   {
      Weather GetWeather(int day);
   }
}
