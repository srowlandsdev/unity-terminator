using Terminator.Logic;
using UnityEditor;
using UnityEngine;

namespace Terminator
{
    class TermMenu
    {
        static TermLogic logic = new();
        static TermNameLogger nameLogger = new();

        [MenuItem("Terminator/Find Longest Directory from Path")]
        static void TFindLongestDir()
        {
            string path = EditorUtility.OpenFolderPanel("", "", "");
            Debug.Log($"Given path to check: {path}");
            logic.TDirectoryLengthCheck(path);
        }

        [MenuItem("Terminator/Terminology Checker")]
        static void TNameCheckTool()
        {
            string path = EditorUtility.OpenFolderPanel("", "", "");
            Debug.Log("Running term checker on local project directory");
            nameLogger.TNameChecker(path);
        }
    }
}
