using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
