using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class StepBackButton : Button {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;

    [SerializeField]
    public MaterialType materialType;

    [SerializeField]
    VideoPlayer videoPlayer;

    [SerializeField]
    float stepBackTime = 2f;

    [SerializeField]
    Image buttonImage;

    private ColorBlock colorBlock;
    private Renderer _imageRenderer;
    // Use this for initialization
    protected override void Awake() {
        base.Awake();
        colorBlock = colors;
    }

    protected override void Start() {
        base.Start();
        if (materialUIOptions != null && materialUIOptions.materialAccentColorMap != null &&
                materialUIOptions.materialAccentColorMap.ContainsKey(materialType)) {
            colorBlock.normalColor = materialUIOptions.materialAccentColorMap[materialType];
            colors = colorBlock;
        }
    }

    private void Update() {
        if (videoPlayer && videoPlayer.time > 0) {
            buttonImage.enabled = true;
            interactable = true;
        } else {
            buttonImage.enabled = false;
            interactable = false;
        }
    }

    public void OnClick() {
        if (videoPlayer.time < stepBackTime) {
            videoPlayer.time = 0;
        } else {
            videoPlayer.time = videoPlayer.time - stepBackTime;
        }
    }
}
