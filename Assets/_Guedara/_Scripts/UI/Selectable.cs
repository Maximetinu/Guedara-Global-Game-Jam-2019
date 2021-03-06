﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider2D))]
public class Selectable : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorHoverTexture;
    public UnityEvent onSelect;
    public bool disableOnSelect = true;

    private void Start()
    {
        if (cursorHoverTexture == null) cursorHoverTexture = Resources.Load("hand") as Texture2D;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            if (onSelect != null)
            {
                ResetCursor();
                onSelect.Invoke();
                if (disableOnSelect)
                {
                    Destroy(this);
                }
            }
        }
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorHoverTexture, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ResetCursor();
    }

    private void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnDestroy()
    {
        ResetCursor();
    }
}