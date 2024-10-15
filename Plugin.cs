using BepInEx;
using BepInEx.Logging;
using BawkLib;
using System.Diagnostics.Tracing;

namespace ModTemplate
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // Until I make this a nuget package please replace the path in Directory.Build.props with your own game path
        // Also go to PluginInfo.cs and put your mods info in it
        void Awake()
        {
            // This is called when the mod is initialized (you shouldnt use this to initialize your mod)
            Events.onLevelLoaded += LevelLoaded;
        }

        void LevelLoaded()
        {
            // This is called whenever a level is loaded
            
        }
    }
}
