using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MenuButton : MonoBehaviour
{
    public float scaleUP = 0.01f;
    public float displacement = 0.2f;
    public bool startSelected = false;
    public UnityEvent<string> onSelect;
    public string Button_ID;
    public GameObject AttachedPanel;

    GazeButton button;

    void Start()
    {
        button = GetComponent<GazeButton>();
        if (startSelected)
        {
            button.disabled = true;
            AnimateSelection();
        }
    }

    public void Select()
    {        
        button.disabled = true;
        if (onSelect != null) onSelect.Invoke(Button_ID);
        if (AttachedPanel != null) AttachedPanel.SetActive(true);
        AnimateSelection();
    }

    public void Unselect(string PressedButtonId)
    {
        if (PressedButtonId.Equals(Button_ID)) return;
        button.disabled = false;
        if (AttachedPanel != null) AttachedPanel.SetActive(false);
        AnimateUnselection();
    }

    private void AnimateSelection()
    {
        LeanTween.moveLocalX(transform.gameObject, displacement, 0.3f).setEase(LeanTweenType.linear);
        LeanTween.scale(transform.gameObject, Vector2.one * (1 + scaleUP), 0.3f).setEase(LeanTweenType.linear);
    }

    private void AnimateUnselection()
    {
        LeanTween.moveLocalX(transform.gameObject, 0, 0.3f).setEase(LeanTweenType.linear);
        LeanTween.scale(transform.gameObject, Vector2.one, 0.3f).setEase(LeanTweenType.linear);
    }
}
