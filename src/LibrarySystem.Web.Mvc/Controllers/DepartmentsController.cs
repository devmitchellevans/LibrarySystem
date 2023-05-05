using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using LibrarySystem.AppService;
using LibrarySystem.AppService.Dto;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Web.Models.Users;
using LibrarySystem.Web.Models.Departments;
using System.Linq;
using Abp.Collections.Extensions;
using Castle.Core.Internal;

namespace LibrarySystem.Web.Controllers
{
    public class DepartmentsController : LibrarySystemControllerBase
    {
        private readonly IDepartmentAppService _departmentAppService;
        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList(),
            };
            return View(model);
        }

        public IActionResult CreateOrEditDepartment(int id)
        {
            var model = new CreateOrEditDepartmentViewModel();
            return View();
        }
    }
}
