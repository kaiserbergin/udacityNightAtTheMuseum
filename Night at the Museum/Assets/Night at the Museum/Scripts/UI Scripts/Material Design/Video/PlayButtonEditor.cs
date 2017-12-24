#if UNITY_EDITOR

using UnityEditor;

[CustomEditor(typeof(PlayButton))]
public class PlayButtonEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

[CustomEditor(typeof(RewindButton))]
public class RewindButtonEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

[CustomEditor(typeof(PauseButton))]
public class PauseButtonEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

[CustomEditor(typeof(StepBackButton))]
public class StepBackButtonEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}

#endif
