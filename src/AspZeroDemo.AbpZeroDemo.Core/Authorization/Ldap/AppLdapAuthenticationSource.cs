using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using AspZeroDemo.AbpZeroDemo.Authorization.Users;
using AspZeroDemo.AbpZeroDemo.MultiTenancy;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}