using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALApi;
using DO;
using DS;


namespace DLObject
{ 
   class DLObject : IDAL

   {
      static Random rnd = new Random();
      #region Singleton
      static readonly DLObject instance = new DLObject();
      static DLObject() { }
      DLObject() { }
      public static DLObject Instance => instance;
      #endregion

      double temperature;

      #region CRUD methods for Temparature
      public double GetTemparture(int day)
      {
         temperature += rnd.NextDouble() * 10 - 5;
         return temperature;
         //   throw new NotImplementedException();
      }
      #endregion

      #region CRUD methods for WindDirection
      public WindDirection GetWindDirection(int day)
      {
         WindDirection direction = DataSource.directions.Find(d => true);
         var directions = (WindDirections[])Enum.GetValues(typeof(WindDirections));
         direction.direction = directions[rnd.Next(0, directions.Length)];

         return direction;
         //   return direction.Clone();
         //  throw new NotImplementedException();
      }
      #endregion
   }
}
