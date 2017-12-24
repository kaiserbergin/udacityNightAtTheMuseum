using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PlayButton : Button {
    [SerializeField]
    public MaterialUIOptions materialUIOptions;

    [SerializeField]
    public MaterialType materialType;

    [SerializeField]
    VideoPlayer videoPlayer;

    [SerializeField]
    Image buttonImage;

    [SerializeField]
    GameObject videoRenderGO;

    private ColorBlock colorBlock;
    private Renderer _imageRenderer;
    private RawImage videoRenderTextureImage;
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
        videoRenderTextureImage = videoRenderGO.GetComponent<RawImage>();
    }

    private void Update() {
        if (videoPlayer && videoPlayer.isPlaying) {
            buttonImage.enabled = false;
            interactable = false;
        } else {
            buttonImage.enabled = true;
            interactable = true;
        }
    }

    public void OnClick() {
        if (!videoPlayer.isPlaying) {
            videoPlayer.Play();
        }
        if(!videoRenderTextureImage.enabled) {
            videoRenderTextureImage.enabled = true;
        }
    }
}