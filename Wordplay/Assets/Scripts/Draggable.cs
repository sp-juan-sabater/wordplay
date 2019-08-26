using System;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[RequireComponent(typeof(GraphicRaycaster))]
[RequireComponent(typeof(CanvasGroup))]
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler 
{
	private Canvas _canvas;
	private CanvasGroup _canvasGroup;

	private void Awake()
	{
		_canvas = GetComponent<Canvas>();
		_canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnBeginDrag(PointerEventData eventData) 
	{
		Debug.Log ("OnBeginDrag");
		
		_canvas.overrideSorting = true;
		_canvas.sortingOrder = 1000; // TODO just in case to be shown in top of everything
		_canvasGroup.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData) 
	{
		Debug.Log ("OnDrag");

		transform.position = eventData.position;
	}
	
	public void OnEndDrag(PointerEventData eventData) 
	{
		Debug.Log ("OnEndDrag");
		
		_canvas.overrideSorting = false;
		_canvasGroup.blocksRaycasts = true;
	}
}
