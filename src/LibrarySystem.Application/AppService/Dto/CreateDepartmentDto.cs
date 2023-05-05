using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.AppService.Dto
{
    [AutoMapFrom(typeof(DepartmentDto))]
    [AutoMapTo(typeof(Department))]
    public class CreateDepartmentDto
    {
        public string Name { get; set; }
    }
}
