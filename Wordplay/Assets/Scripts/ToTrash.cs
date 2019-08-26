using UnityEngine;
using System.Collections;
using System.Dynamic;
using UnityEngine.EventSystems;

public class ToTrash : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
		Debug.Log ("OnDrop: Delete word");
        Destroy(eventData.pointerDrag);
    }
}
