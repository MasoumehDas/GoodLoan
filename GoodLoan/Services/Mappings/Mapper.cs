using Contracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using Domain.Entities;

namespace Services
{
    public class Mapper<T, U> where T : class
    {
        private Dictionary<string, List<object>> _keyValues;

        public Mapper(Dictionary<string, List<object>> keyValues)
        {
            _keyValues = keyValues;
        }

        public List<U> MapProp(List<T> TSource, U TDestination)
        {

            List<U> _EnumsDtos = new List<U>();
            TSource.ForEach(a =>
            {
                U _EnumsDto;
                _EnumsDto = Mapp(TSource[0], TDestination);
                _EnumsDtos.Add(_EnumsDto);
            });

            return _EnumsDtos;
        }

        private U Mapp(T TSource, U TDestination)
        {


            Type T1 = typeof(T);

            //Type T1 = TSource.GetType();
            Type T2 = TDestination.GetType();

            PropertyInfo[] sourceProprties = T1.GetProperties(BindingFlags.Instance | BindingFlags.Public);



            foreach (var sourceProp in sourceProprties)
            {


                object sourceVal = sourceProp.GetValue(TSource, null);
                string sourceName = sourceProp.Name;
                PropertyInfo targetProp = T2.GetProperty(sourceProp.Name);
                if (targetProp != null)
                {

                    if (sourceProp.PropertyType.IsClass)
                    {
                        GetNodes(sourceProp);
                    }
                    TDestination.GetType().GetProperty(sourceName).SetValue(TDestination, sourceVal, null);




                }

            }

            return TDestination;
        }


        public void GetNodes(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                return;
            }

            string ClassName = propertyInfo.PropertyType.Name;
            var TDestination = _keyValues.FirstOrDefault(a => a.Key == ClassName);

            Assembly assembly = typeof(User).Assembly;
            Type T1 = assembly.GetType(propertyInfo.PropertyType.FullName);
           
            Type T2 = TDestination.Value[0].GetType();
            

            
            string sourceName = propertyInfo.Name;

            PropertyInfo[] source = propertyInfo.PropertyType.GetProperties();
            PropertyInfo[] props = T1.GetProperties();
            
            foreach (var sourceProp in source)
            {


                var sourceVal = sourceProp.GetValue(TDestination.Value[1]);
                string sourceName1 = sourceProp.Name;
                PropertyInfo targetProp = T2.GetProperty(sourceProp.Name);
                //if (targetProp != null)
                //{

                //    if (sourceProp.PropertyType.IsClass)
                //    {
                //        GetNodes(sourceProp);
                //    }
                    TDestination.GetType().GetProperty(sourceName).SetValue(TDestination, sourceVal, null);




                //}

            }

        }
        
    }
    public  class MapObject
    {
        

        public static List<UserDto> MappingUserDto(List<User> result)
        {
            Dictionary<string, List<object>> valuePairs = new Dictionary<string, List<object>>();
            valuePairs.Add("UserRole", new List<object> { new UserRoleDto(), new UserRole() });
            valuePairs.Add("Loan", new List<object> { new LoanDto(), new Loan() });
            Mapper<User, UserDto> mapper = new Mapper<User, UserDto>(valuePairs);
            var list = mapper.MapProp(result, new UserDto());
            return list;
        }
        public static List<_EnumsDto> Mapping_EnumsDto(List<_Enums> result)
        {
            Dictionary<string, List<object>> valuePairs = new Dictionary<string, List<object>>();
            Mapper<_Enums, _EnumsDto> mapper = new Mapper<_Enums, _EnumsDto>(valuePairs);
            var list = mapper.MapProp(result, new _EnumsDto());
            return list;
        }
    }
   

}


