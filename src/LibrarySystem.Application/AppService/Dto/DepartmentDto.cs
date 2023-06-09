﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.AppService.Dto
{
    [AutoMapFrom(typeof(Department))]

    public class DepartmentDto: EntityDto<int>
    {
        public string Name { get; set; }
    }
}
