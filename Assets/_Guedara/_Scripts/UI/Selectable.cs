using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider))]
public class Selectable : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorHoverTexture;
    public UnityEvent onSelect;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("On pointer down");
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            onSelect.Invoke();
        }
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorHoverTexture, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}