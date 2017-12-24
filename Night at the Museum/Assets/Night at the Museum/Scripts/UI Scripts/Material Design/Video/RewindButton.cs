using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class RewindButton : Button {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;

    [SerializeField]
    public MaterialType materialType;

    [SerializeField]
    VideoPlayer videoPlayer;

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
        if (videoPlayer.isPlaying) {
            videoPlayer.time = 0;
        }
    }
}
