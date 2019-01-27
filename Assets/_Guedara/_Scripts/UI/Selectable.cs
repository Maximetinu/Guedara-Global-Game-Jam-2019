using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider))]
public class Selectable : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent onSelect;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("On pointer down");
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            onSelect.Invoke();
        }
    }

}