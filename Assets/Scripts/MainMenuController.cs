using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    private void Start()
    {
    }

    public void Close()
    {
        LeanTween.scale(gameObject, Vector2.zero, 1.0f).setEase(LeanTweenType.linear);
    }
}
