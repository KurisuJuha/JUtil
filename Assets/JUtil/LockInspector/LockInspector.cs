using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace JuhaKurisu.JUtil
{
    public static class LockInspector
    {
        [MenuItem("Tools/Toggle Inspector Lock %l")]
        private static void ToggleLock()
        {
            var tracker = ActiveEditorTracker.sharedTracker;
            tracker.isLocked = !tracker.isLocked;
            tracker.ForceRebuild();
        }
    }
}