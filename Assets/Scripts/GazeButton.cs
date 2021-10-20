using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class GazeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool pointerHover = false;
    private float pointerDownTimer = 0;
    public bool disabled = false;

    public float requiredGazeTime = 1;
    public UnityEvent onGaze;

    [SerializeField]
    private Image fillImage;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (disabled) return;
        pointerHover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (pointerHover)
        {
            pointerDownTimer += Time.deltaTime;
            if(pointerDownTimer >= requiredGazeTime)
            {
                if (onGaze != null) onGaze.Invoke();
                Reset();
            }
            fillImage.fillAmount = pointerDownTimer / requiredGazeTime;
        }
        
    }

    private void Reset()
    {
        pointerHover = false;
        pointerDownTimer = 0;
        fillImage.fillAmount = 0;
    }
}
