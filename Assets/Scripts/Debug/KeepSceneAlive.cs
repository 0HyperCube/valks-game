using UnityEngine;

public class KeepSceneAlive : MonoBehaviour
{
    public bool KeepSceneViewActive;

    private void Start()
    {
        if (KeepSceneViewActive && Application.isEditor)
        {
            UnityEditor.SceneView.FocusWindowIfItsOpen(typeof(UnityEditor.SceneView));
        }
    }
}