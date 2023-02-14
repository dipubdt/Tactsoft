﻿using Tactsoft.Service.Services.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactsoft.Service.Services;
using Tactsoft.Core.Entities;

namespace Tactsoft.Service.Dependency
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
           

            services.AddScoped<IIndustialTypeService, IndustialTypeService>();
            services.AddScoped<IServiceTypeService, ServiceTypeService>();
            services.AddScoped<IJobCategoryService, JobCategoryService>();

            services.AddScoped<IJobSubCategoryService, JobSubCategoryService>();
            services.AddScoped<IEmploymentStatusService, EmploymentStatusService>();

            services.AddScoped<IJobLevelService, JobLevelService>();
            services.AddScoped<IWorkPlaceService, WorkPlaceService>();

            services.AddScoped<IJobLocationService, JobLocationService>();
            services.AddScoped<IResumeReceivingOptionsService, ResumeReceivingOptionsService>();

            services.AddScoped<ICountryssService, CountryssService>();
            services.AddScoped<IDistrictsService, DistrictsService>();

             services.AddScoped<IThanaService, ThanaService>();


        }
    }
}
