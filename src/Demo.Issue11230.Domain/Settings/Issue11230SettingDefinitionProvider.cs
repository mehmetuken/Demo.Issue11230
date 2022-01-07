using Volo.Abp.Settings;

namespace Demo.Issue11230.Settings
{
    public class Issue11230SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Issue11230Settings.MySetting1));
        }
    }
}
