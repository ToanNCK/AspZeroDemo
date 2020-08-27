using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using AspZeroDemo.AbpZeroDemo.Authentication.TwoFactor.Google;
using AspZeroDemo.AbpZeroDemo.Authorization;
using AspZeroDemo.AbpZeroDemo.Authorization.Roles;
using AspZeroDemo.AbpZeroDemo.Authorization.Users;
using AspZeroDemo.AbpZeroDemo.Editions;
using AspZeroDemo.AbpZeroDemo.MultiTenancy;

namespace AspZeroDemo.AbpZeroDemo.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
