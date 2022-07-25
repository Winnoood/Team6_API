using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Team6_API.Model;
using System.Threading.Tasks;

namespace Team6_API.Helper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            //Mapping with Database
            CreateMap<Employee, EmployeeDB>().ReverseMap();
            CreateMap<Manager, ManagerDB>().ReverseMap();
            CreateMap<LeaveDetails, LeaveDetailsDB>().ReverseMap();   
        }
    }
}
