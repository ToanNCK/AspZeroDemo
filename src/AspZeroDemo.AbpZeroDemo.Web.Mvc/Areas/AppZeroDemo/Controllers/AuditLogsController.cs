using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Auditing;
using AspZeroDemo.AbpZeroDemo.Auditing.Dto;
using AspZeroDemo.AbpZeroDemo.Authorization;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.AuditLogs;
using AspZeroDemo.AbpZeroDemo.Web.Controllers;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Controllers
{
    [Area("AppZeroDemo")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroDemoControllerBase
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public AuditLogsController(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> EntityChangeDetailModal(EntityChangeListDto entityChangeListDto)
        {
            var output = await _auditLogAppService.GetEntityPropertyChanges(entityChangeListDto.Id);

            var viewModel = new EntityChangeDetailModalViewModel(output, entityChangeListDto);

            return PartialView("_EntityChangeDetailModal", viewModel);
        }
    }
}