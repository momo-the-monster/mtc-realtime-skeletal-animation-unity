using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider2D))]
public class DraggableSprite : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public static GameObject DraggedInstance;

    Vector3 _startPosition;
    Vector3 _touchOffset;
    float _zDistanceToCamera;
    int _touchIndex = -1;

    public void OnBeginDrag(PointerEventData eventData)
    {
        DraggedInstance = gameObject;
        _startPosition = transform.position;
        _zDistanceToCamera = Mathf.Abs(_startPosition.z - Camera.main.transform.position.z);

        _touchIndex = eventData.pointerId;
        Vector2 screenPosition = (_touchIndex == -1) ? new Vector2(Input.mousePosition.x, Input.mousePosition.y) : Input.GetTouch(_touchIndex).position;
        _touchOffset = _startPosition - Camera.main.ScreenToWorldPoint(
            new Vector3(screenPosition.x, screenPosition.y, _zDistanceToCamera)
        );
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerId != _touchIndex)
            return;

        Vector2 screenPosition = (_touchIndex == -1) ? new Vector2(Input.mousePosition.x, Input.mousePosition.y) : Input.GetTouch(_touchIndex).position;

        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(screenPosition.x, screenPosition.y, _zDistanceToCamera)
            ) + _touchOffset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        DraggedInstance = null;
        _touchOffset = Vector3.zero;
        _touchIndex = -1;
    }

}
