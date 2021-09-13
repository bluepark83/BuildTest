using UnityEditor;

public class ScriptBatch 
{
    [MenuItem("MyTools/Windows Build With Postprocess")]
    public static void BuildGame ()
    {
        // Get filename.
        string path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "", "");
        string[] levels = new string[] {"Assets/Scenes/Scene1.unity"};

        // Build player.
        BuildPipeline.BuildPlayer(levels, "BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        UnityEngine.Debug.Log("Complete Build");
    }
}