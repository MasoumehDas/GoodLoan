using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Services
{
   public  class  Mapper<T,U> where T :class 
    {
        
        public static U MapProp(T TSource, U TDestination)
        {

            Type T1 = TSource.GetType();
            Type T2 = TDestination.GetType();

            PropertyInfo[] sourceProprties = T1.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            

            foreach (var sourceProp in sourceProprties)
            {
                
                object osourceVal = sourceProp.GetValue(TSource, null);
                string dd = sourceProp.Name;
                PropertyInfo targetProp = T2.GetProperty(sourceProp.Name);
                //int entIndex = Array.IndexOf(targetProprties, sourceProp);
                //if (entIndex >= 0)
                //{
                 //   var targetProp = targetProprties[entIndex];
                    targetProp.SetValue(TDestination, osourceVal);
                //}
            }
           
            return TDestination;
        }
    }


    
}

