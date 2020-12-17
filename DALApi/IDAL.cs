using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DALApi
{
   /// <summary>
   /// the interface to implement the service contract of our objects
   /// will have CRUD methods for each of our DO objects
   /// </summary>
   public interface IDAL
   {
      #region CRUD Temparture
      double GetTemparture(int day);
      #endregion
      #region CRUD WindDirection
      WindDirection GetWindDirection(int day);
      #endregion

   }
}
