#if UNITY_EDITOR
using UnityEditor;



class BuildWindowsPlayer
{
    static void PerformBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/SampleScene.unity" },
            locationPathName = "./WindowsBuild/Build.exe",
            target = BuildTarget.StandaloneWindows,
            options = BuildOptions.Development
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
   
    }
    
}
#endif