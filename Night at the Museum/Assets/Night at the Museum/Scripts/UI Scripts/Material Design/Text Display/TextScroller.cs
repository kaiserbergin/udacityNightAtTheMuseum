using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TextScroller : MonoBehaviour {

    [SerializeField]
    public float scrollDistance = 10f;

    [SerializeField]
    public float scrollAnimationLength = .25f;

    [SerializeField]
    public GameObject materialTextDisplayContainer;

    private MaterialTextDisplay materialTextDisplay;
    private float scrollPosition;
    private float originalPosition;
    private float textHeight;
    private RectTransform rectTransform;

    private void Awake() {
        materialTextDisplay = materialTextDisplayContainer.GetComponentInChildren<MaterialTextDisplay>();
        rectTransform = transform.GetComponent<RectTransform>();

        textHeight = materialTextDisplay.preferredHeight;        
    }

    private void Start() {Vector2 sizeDelta = rectTransform.sizeDelta;
        sizeDelta.y = textHeight;
        rectTransform.sizeDelta = sizeDelta;

        scrollPosition = rectTransform.localPosition.y;
        originalPosition = rectTransform.localPosition.y;
    }

    public bool CanScrollUp() {
        return scrollPosition > originalPosition;
    }

    public bool CanScrollDown() {
        return scrollPosition < textHeight / 2;
    }

    public void ScrollUp() {
        float updatedScrollHeight = scrollPosition + scrollDistance * -1;
        if (updatedScrollHeight < originalPosition) updatedScrollHeight = originalPosition;
        Sequence scrollUpSequence = DOTween.Sequence();        
        scrollUpSequence.Append(transform.DOLocalMoveY(updatedScrollHeight, scrollAnimationLength));
        scrollPosition = updatedScrollHeight;
        Debug.Log(scrollPosition);
    }

    public void ScrollDown() {
        float updatedScrollHeight = scrollPosition + scrollDistance;        
        if (updatedScrollHeight > textHeight / 2) updatedScrollHeight = textHeight / 2;
        Vector3 test = transform.localPosition;
        Sequence scrollDownSequence = DOTween.Sequence();
        scrollDownSequence.Append(transform.DOLocalMoveY(updatedScrollHeight, scrollAnimationLength));
        scrollPosition = updatedScrollHeight;
    }
}
