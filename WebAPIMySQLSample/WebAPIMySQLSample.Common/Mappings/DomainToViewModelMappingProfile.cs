using AutoMapper;
using WebAPIMySQLSample.Common.Entities;
using WebAPIMySQLSample.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMySQLSample.Common.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        protected override void Configure()
        {

            

            /*
             * NOTE: We do not need reverse mapping explictly. This is because it can be performed automatically.
            
            If you don't need to define any custom mapping logic for the reverse mapping, then you can just call ReverseMap() off of CreateMap():

            AutoMapper.Mapper.CreateMap<WorkOrder, WorkOrderViewModel>().ReverseMap();

    */
           

            base.CreateMap<Employee, EmployeeViewModel>()
           .ForMember(vm => vm.AccountUniqueID, map => map.MapFrom(m => m.AccountUniqueID))
           .ForMember(vm => vm.CreatedOn, map => map.MapFrom(m => m.CreatedOn))
           //.ForMember(vm => vm.CompanyRoleUniqueID, map => map.MapFrom(m => m.CompanyRoleUniqueID))
           .ForMember(vm => vm.LastModifiedDateTime, map => map.MapFrom(m => m.LastModifiedDateTime))
           .ForMember(vm => vm.CompanyUniqueID, map => map.MapFrom(m => m.CompanyUniqueID))
           .ForMember(vm => vm.EmployeeFirstName, map => map.MapFrom(m => m.EmployeeFirstName))
           .ForMember(vm => vm.EmployeeLastName, map => map.MapFrom(m => m.EmployeeLastName))
           .ForMember(vm => vm.EmployeeUniqueID, map => map.MapFrom(m => m.EmployeeUniqueID))
           .ForMember(vm => vm.EmployeeUserName, map => map.MapFrom(m => m.EmployeeUserName))
           .ForMember(vm => vm.IsPasswordReset, map => map.MapFrom(m => m.IsPasswordReset))
           .ForMember(vm => vm.StatusId, map => map.MapFrom(m => m.StatusId));

            base.CreateMap<Employee, EmployeeViewModel>().ReverseMap();

           


            //Mapper.CreateMap<Movie, MovieViewModel>()
            //    .ForMember(vm => vm.Genre, map => map.MapFrom(m => m.Genre.Name))
            //    .ForMember(vm => vm.GenreId, map => map.MapFrom(m => m.Genre.ID))
            //    .ForMember(vm => vm.IsAvailable, map => map.MapFrom(m => m.Stocks.Any(s => s.IsAvailable)))
            //    .ForMember(vm => vm.NumberOfStocks, map => map.MapFrom(m => m.Stocks.Count))
            //    .ForMember(vm => vm.Image, map => map.MapFrom(m => string.IsNullOrEmpty(m.Image) == true ? "unknown.jpg" : m.Image));

            //Mapper.CreateMap<Genre, GenreViewModel>()
            //    .ForMember(vm => vm.NumberOfMovies, map => map.MapFrom(g => g.Movies.Count()));
            //// code omitted
            //Mapper.CreateMap<Customer, CustomerViewModel>();




            base.CreateMap<Accounts, AccountsViewModel>()
              .ForMember(vm => vm.CreatedOn, map => map.MapFrom(m => m.CreatedOn))
              .ForMember(vm => vm.LastModifiedDatetime, map => map.MapFrom(m => m.LastModifiedDateTime))
              .ForMember(vm => vm.AccountName, map => map.MapFrom(m => m.AccountName))
              .ForMember(vm => vm.AccountAddress, map => map.MapFrom(m => m.AccountAddress))
              .ForMember(vm => vm.AccountCity, map => map.MapFrom(m => m.AccountCity))
               .ForMember(vm => vm.AccountStateId, map => map.MapFrom(m => m.AccountStateId))
               .ForMember(vm => vm.AccountUniqueID, map => map.MapFrom(m => m.AccountUniqueID))
                  .ForMember(vm => vm.CompanyUniqueID, map => map.MapFrom(m => m.CompanyUniqueId))
               .ForMember(vm => vm.LicenseId, map => map.MapFrom(m => m.LicenseId))
               .ForMember(vm => vm.StatusId, map => map.MapFrom(m => m.StatusId))
            

     ;

            base.CreateMap<Accounts, AccountsViewModel>().ReverseMap();




            base.CreateMap<Company, CompanyViewModel>()
              .ForMember(vm => vm.CreatedOn, map => map.MapFrom(m => m.CreatedOn))
              .ForMember(vm => vm.LastModifiedDatetime, map => map.MapFrom(m => m.LastModifiedDateTime))
              .ForMember(vm => vm.CompanyAddress, map => map.MapFrom(m => m.CompanyAddress))
              .ForMember(vm => vm.CompanyCity, map => map.MapFrom(m => m.CompanyCity))
               .ForMember(vm => vm.CompanyName, map => map.MapFrom(m => m.CompanyName))
               .ForMember(vm => vm.CompanyUniqueID, map => map.MapFrom(m => m.CompanyUniqueID))
     ;

        }
    }
}