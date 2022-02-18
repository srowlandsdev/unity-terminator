using System.IO;
using UnityEditor;
using UnityEngine;

namespace Terminator.Logic
{
    public class TermLogic
    {
        const int maxCharLengh = 255;

        public void TDirectoryLengthCheck(string path)
        {
            int currentHighCharCount = 0;
            int numberOfHighCountPasses = 0;

            string fullPath = Path.GetFullPath(path);

            Debug.Log($"Full path is: {fullPath}");

            string[] paths = Directory.GetDirectories(fullPath, "*", SearchOption.AllDirectories);

            Debug.Log($"Number of directories found: {paths.Length}");

            string longPath = string.Empty;

            foreach (string dir in paths)
            {
                Debug.Log($"Checking directory: {dir}");

                if (dir.Length > currentHighCharCount)
                {
                    Debug.Log($"{dir} is higher than current high path count, setting this path as new high path");

                    longPath = dir;
                    currentHighCharCount = dir.Length;
                    numberOfHighCountPasses += 1;
                }

                if (dir.Length >= maxCharLengh)
                {
                    Debug.LogWarning($"Directory exceeding or at limit of max character for a path on disk! {dir}");
                }
            }
            Debug.Log($"Longest path in project is: [{longPath}][{longPath.Length}]");
            Debug.Log($"Number of times high path was surpassed: [{numberOfHighCountPasses}]");
        }
    }

}