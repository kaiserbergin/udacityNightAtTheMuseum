#if UNITY_EDITOR

using UnityEditor;

[CustomEditor(typeof(MaterialTextDisplay))]
public class MaterialTextDisplayEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

#endif
