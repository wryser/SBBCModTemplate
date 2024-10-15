using BepInEx;
using BepInEx.Logging;

namespace ModTemplate
{
    [BepInPlugin(PluginInfo.Version, PluginInfo.Version, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // Until I make this a nuget package please replace the path in Directory.Build.props with your own game path
        // Also double click on the csproj and replace the assembly name
        void Awake()
        {
            // This is called when the mod is initialized (you shouldnt use this to initialize your mod)

        }
    }
}
