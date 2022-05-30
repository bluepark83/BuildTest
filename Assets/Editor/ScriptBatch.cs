using UnityEditor;
using UnityEngine;

public class ScriptBatch
{
    [MenuItem("MyTools/Windows Build With Postprocess")]
    public static void BuildGame()
    {
        var commandLineArgs = System.Environment.GetCommandLineArgs();
        foreach (var argument in commandLineArgs)
        {
            Debug.Log(argument);   
        }
        
        // // Get filename.
        // string path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "", "");
        // string[] levels = new string[] { "Assets/Scenes/Scene1.unity" };
        //
        // // Build player.
        // BuildPipeline.BuildPlayer(levels, "./Build/BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        UnityEngine.Debug.Log("Complete Build");
    }


    static string GetArg(string name)
    {
        var args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == name && args.Length > i + 1)
            {
                return args[i + 1];
            }
        }

        return default;
    }
}