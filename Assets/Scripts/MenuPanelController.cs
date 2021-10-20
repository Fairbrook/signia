using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MenuPanelController : MonoBehaviour
{
    public UnityEvent<string> onSelect;
    public void ButtonSelected(string SelectedButtonId)
    {
        Debug.Log("type: "+ SelectedButtonId);
        if(onSelect != null)
        {
            onSelect.Invoke(SelectedButtonId);
        }
    }
}
