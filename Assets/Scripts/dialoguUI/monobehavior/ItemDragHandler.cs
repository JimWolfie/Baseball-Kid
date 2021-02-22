using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof (CanvasGroup))]
public class ItemDragHandler : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]protected ItemSlotUI itemSlotUI = null;
    private CanvasGroup canvasGroup = null;
    private Transform orginalParent = null;
    private bool isHovering = false;
  
    public ItemSlotUI ItemSlotUI => itemSlotUI;

    void Start()=>canvasGroup = GetComponent<CanvasGroup>();

    private void OnDisable()
    {
        if(isHovering)
        {
            isHovering=false;
            //raise event
        }
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            //raise event
            orginalParent = transform.parent; //store for later
            transform.SetParent(transform.parent.parent); //set parent two up
            canvasGroup.blocksRaycasts = false; //we care whatts bellow 
        }
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            transform.position = Input.mousePosition; //mouse can move now
        }
    }
    public virtual void OnPointerUp(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            transform.SetParent(orginalParent); //undoing on button down
            transform.localPosition = Vector3.zero;
            canvasGroup.blocksRaycasts = true;
        }
    }

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        //onRaise
        isHovering = true;
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        //onRaise
        isHovering = false;
    }
}
