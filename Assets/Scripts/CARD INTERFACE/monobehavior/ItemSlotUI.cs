﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ItemSlotUI : MonoBehaviour, IDropHandler
{
    [SerializeField]protected Image iconImage = null;
    public int SlotIndex {get; private set; }
    public abstract InventoryObject SlotItem{get; set;}

    private void OnEnable()
    {
        UpdateSlotUI();
    }

    protected virtual void Start()
    {
        SlotIndex = transform.GetSiblingIndex();
        UpdateSlotUI();
    }

    public abstract void OnDrop(PointerEventData eventData);

    public abstract void UpdateSlotUI();

    protected virtual void EnableSlotUI(bool enable) => iconImage.enabled = enable;
}
