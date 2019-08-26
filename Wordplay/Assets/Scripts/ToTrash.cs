using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ToTrash : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {

        Destroy(eventData.pointerDrag);
    }
}
