using System;
using UnityEngine;
using UnityEngine.UI;

public class MaterialPanelFormatter : MonoBehaviour {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;
    [SerializeField]
    public MaterialType materialType;

    private Image panelImage;

    private void Awake() {
        panelImage = transform.GetComponent<Image>();
    }
    // Use this for initialization
    void Start() {
        if (materialUIOptions != null && materialUIOptions.materialAccentColorMap != null &&
                materialUIOptions.materialAccentColorMap.ContainsKey(materialType)) {
            panelImage.color = materialUIOptions.materialAccentColorMap[materialType];
        }            
    }

    // Update is called once per frame
    void Update() {

    }
}
