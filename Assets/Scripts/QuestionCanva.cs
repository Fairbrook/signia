using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCanva : MonoBehaviour
{
    CanvasGroup canvas;

    private void Start(){
        gameObject.SetActive(false);
        canvas = gameObject.GetComponent<CanvasGroup>();
        canvas.alpha = 0;
    }

    private void hide(){
        gameObject.SetActive(false);
    }

    public void Close()
    {
        LeanTween.alphaCanvas(canvas, 0f, 1.0f).setOnComplete(hide).setEase(LeanTweenType.linear);
    }

    public void Open()
    {
        gameObject.SetActive(true);
        canvas = gameObject.GetComponent<CanvasGroup>();
        LeanTween.alphaCanvas(canvas,1f, 1.0f).setEase(LeanTweenType.linear);
    }

}
