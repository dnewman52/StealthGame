using UnityEditor;



class BuildWindowsPlayer
{
    static void PerformBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "./WindowsBuild/Build.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows;
        buildPlayerOptions.options = BuildOptions.Development;
        
        BuildPipeline.BuildPlayer(buildPlayerOptions);
   
    }
    
}
