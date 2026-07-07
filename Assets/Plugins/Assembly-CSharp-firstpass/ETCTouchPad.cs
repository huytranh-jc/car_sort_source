using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ETCTouchPad : ETCBase, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	[Serializable]
	public class OnMoveStartHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnMoveHandler : UnityEvent<Vector2>
	{
	}

	[Serializable]
	public class OnMoveSpeedHandler : UnityEvent<Vector2>
	{
	}

	[Serializable]
	public class OnMoveEndHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnTouchStartHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnTouchUPHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnDownUpHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnDownDownHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnDownLeftHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnDownRightHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressUpHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressDownHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressLeftHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressRightHandler : UnityEvent
	{
	}

	[SerializeField]
	public OnMoveStartHandler onMoveStart;

	[SerializeField]
	public OnMoveHandler onMove;

	[SerializeField]
	public OnMoveSpeedHandler onMoveSpeed;

	[SerializeField]
	public OnMoveEndHandler onMoveEnd;

	[SerializeField]
	public OnTouchStartHandler onTouchStart;

	[SerializeField]
	public OnTouchUPHandler onTouchUp;

	[SerializeField]
	public OnDownUpHandler OnDownUp;

	[SerializeField]
	public OnDownDownHandler OnDownDown;

	[SerializeField]
	public OnDownLeftHandler OnDownLeft;

	[SerializeField]
	public OnDownRightHandler OnDownRight;

	[SerializeField]
	public OnDownUpHandler OnPressUp;

	[SerializeField]
	public OnDownDownHandler OnPressDown;

	[SerializeField]
	public OnDownLeftHandler OnPressLeft;

	[SerializeField]
	public OnDownRightHandler OnPressRight;

	public ETCAxis axisX;

	public ETCAxis axisY;

	public bool isDPI;

	private Image cachedImage;

	private Vector2 tmpAxis;

	private Vector2 OldTmpAxis;

	private GameObject previousDargObject;

	private bool isOut;

	private bool isOnTouch;

	private bool cachedVisible;

	protected override void Awake()
	{
	}

	public override void OnEnable()
	{
	}

	public override void Start()
	{
	}

	protected override void UpdateControlState()
	{
	}

	protected override void DoActionBeforeEndOfFrame()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void UpdateTouchPad()
	{
	}

	protected override void SetVisible(bool forceUnvisible = false)
	{
	}

	protected override void SetActivated()
	{
	}
}
