using UnityEditor;
using UnityEngine;

namespace GGJ.Poached.Editor
{
    public static class ResetPositionAndRotation
    {
        [MenuItem("GameObject/Reset Position and Rotation #r")]
        public static void ResetPosAndRot()
        {
            GameObject go = Selection.activeGameObject;
            if (go == null) return;
            Undo.RegisterCompleteObjectUndo(go.transform, "Position and Rotation Reset");
            go.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        }
    }
}