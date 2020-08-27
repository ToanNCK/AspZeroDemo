using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using AspZeroDemo.AbpZeroDemo.Authorization;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Startup
{
    public class AppZeroDemoNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppZeroDemoPageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppZeroDemo/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                    AppZeroDemoPageNames.Host.Tenants,
                    L("Tenants"),
                    url: "AppZeroDemo/Tenants",
                    icon: "flaticon-list-3",
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppZeroDemoPageNames.Host.Editions,
                        L("Editions"),
                        url: "AppZeroDemo/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppZeroDemoPageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppZeroDemo/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppZeroDemoPageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppZeroDemo/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_OrganizationUnits)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.Roles,
                            L("Roles"),
                            url: "AppZeroDemo/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.Users,
                            L("Users"),
                            url: "AppZeroDemo/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.Languages,
                            L("Languages"),
                            url: "AppZeroDemo/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Languages)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppZeroDemo/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_AuditLogs)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppZeroDemo/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Maintenance)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppZeroDemo/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppZeroDemo/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_UiCustomization)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "AppZeroDemo/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_WebhookSubscription)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Common.DynamicEntityParameters,
                            L("DynamicParameters"),
                            icon: "flaticon-interface-8"
                        ).AddItem(new MenuItemDefinition(
                                AppZeroDemoPageNames.Common.DynamicParameters,
                                L("Definitions"),
                                url: "AppZeroDemo/DynamicParameter",
                                icon: "flaticon-map",
                                permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_DynamicParameters)
                            )
                        )
                        .AddItem(new MenuItemDefinition(
                                AppZeroDemoPageNames.Common.EntityDynamicParameters,
                                L("EntityDynamicParameters"),
                                url: "AppZeroDemo/EntityDynamicParameter",
                                icon: "flaticon-map",
                                permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_EntityDynamicParameters)
                            )
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Host.Settings,
                            L("Settings"),
                            url: "AppZeroDemo/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppZeroDemoPageNames.Tenant.Settings,
                            L("Settings"),
                            url: "AppZeroDemo/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_Settings)
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppZeroDemoPageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "AppZeroDemo/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroDemoConsts.LocalizationSourceName);
        }
    }
}
