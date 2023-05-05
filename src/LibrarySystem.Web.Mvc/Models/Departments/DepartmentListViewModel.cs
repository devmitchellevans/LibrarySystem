using LibrarySystem.AppService.Dto;
using LibrarySystem.Roles.Dto;
using System.Collections.Generic;
namespace LibrarySystem.Web.Models.Departments
{
    public class DepartmentListViewModel
    {
        public List<DepartmentDto> Departments { get; set; }
    }
}
