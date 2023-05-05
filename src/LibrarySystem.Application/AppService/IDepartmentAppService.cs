using Abp.Application.Services.Dto;
using LibrarySystem.AppService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.AppService
{
    public interface IDepartmentAppService
    {
        Task<PagedResultDto<DepartmentDto>> GetAllAsync(PagedDepartmentResultRequestDto input);
        Task<DepartmentDto> CreateAsync(CreateDepartmentDto input);
    }
}
