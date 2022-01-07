using Demo.Issue11230.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Demo.Issue11230.Permissions
{
    public class Issue11230PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Issue11230Permissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Issue11230Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Issue11230Resource>(name);
        }
    }
}
