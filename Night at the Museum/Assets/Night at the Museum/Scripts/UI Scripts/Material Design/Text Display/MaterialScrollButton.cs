using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum ScrollDirection { UP, DOWN };
public class MaterialScrollButton : Button {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;

    [SerializeField]
    public ScrollDirection scrollDirection;

    [SerializeField]
    public MaterialType materialType;

    [SerializeField]
    public TextScroller textScroller;

    private ColorBlock colorBlock;

    protected override void Awake() {
        base.Awake();
        colorBlock = colors;
    }

    protected override void Start() {
        base.Start();
        interactable = CanScroll();
        if (materialUIOptions != null && materialUIOptions.materialAccentColorMap != null &&
                materialUIOptions.materialAccentColorMap.ContainsKey(materialType)) {
            colorBlock.normalColor = materialUIOptions.materialAccentColorMap[materialType];
            colors = colorBlock;
        }
    }

    // Update is called once per frame
    void Update() {
        interactable = CanScroll();
    }

    private bool CanScroll() {
        if (scrollDirection.Equals(ScrollDirection.DOWN)) {
            return textScroller.CanScrollDown();
        }
        return textScroller.CanScrollUp();
    }
}
