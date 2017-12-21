using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class MaterialTextDisplay : Text  {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;
    [SerializeField]
    public MaterialType materialType;

    public bool canScrollUp = false;
    public bool canScrollDown = true;
    protected override void Start() {
        base.Start();
        if (materialUIOptions != null && materialUIOptions.materialTextColorMap != null &&
                materialUIOptions.materialTextColorMap.ContainsKey(materialType)) {
            color = materialUIOptions.materialTextColorMap[materialType];           
        }
    }    
}
