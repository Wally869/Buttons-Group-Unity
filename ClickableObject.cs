using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickableObject : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public int mIdObject;
    private ButtonsGroupController _mButtonsGroupController;

    void Start()
    {
        _mButtonsGroupController = transform.parent.GetComponent<ButtonsGroupController>(); ;
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _mButtonsGroupController.NotifySelection(mIdObject);

    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _mButtonsGroupController.NotifyHovering(mIdObject);

    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        _mButtonsGroupController.NotifyStoppedHovering(mIdObject);  
    }
}
