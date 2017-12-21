#if UNITY_EDITOR

using UnityEditor;

[CustomEditor(typeof(MaterialScrollButton))]
public class MaterialScrollButtonEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

#endif
