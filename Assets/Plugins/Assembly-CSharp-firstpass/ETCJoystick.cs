using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Serializable]
public class ETCJoystick : ETCBase, IPointerEnterHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IPointerDownHandler, IPointerUpHandler
{
	[Serializable]
	public class OnMoveStartHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnMoveSpeedHandler : UnityEvent<Vector2>
	{
	}

	[Serializable]
	public class OnMoveHandler : UnityEvent<Vector2>
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
	public class OnTouchUpHandler : UnityEvent
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

	public enum JoystickArea
	{
		UserDefined = 0,
		FullScreen = 1,
		Left = 2,
		Right = 3,
		Top = 4,
		Bottom = 5,
		TopLeft = 6,
		TopRight = 7,
		BottomLeft = 8,
		BottomRight = 9
	}

	public enum JoystickType
	{
		Dynamic = 0,
		Static = 1
	}

	public enum RadiusBase
	{
		Width = 0,
		Height = 1,
		UserDefined = 2
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
	public OnTouchUpHandler onTouchUp;

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

	public JoystickType joystickType;

	public bool allowJoystickOverTouchPad;

	public RadiusBase radiusBase;

	public float radiusBaseValue;

	public ETCAxis axisX;

	public ETCAxis axisY;

	public RectTransform thumb;

	public JoystickArea joystickArea;

	public RectTransform userArea;

	public bool isTurnAndMove;

	public float tmSpeed;

	public float tmAdditionnalRotation;

	public AnimationCurve tmMoveCurve;

	public bool tmLockInJump;

	private Vector3 tmLastMove;

	private Vector2 thumbPosition;

	private bool isDynamicActif;

	private Vector2 tmpAxis;

	private Vector2 OldTmpAxis;

	private bool isOnTouch;

	[SerializeField]
	private bool isNoReturnThumb;

	private Vector2 noReturnPosition;

	private Vector2 noReturnOffset;

	[SerializeField]
	private bool isNoOffsetThumb;

	public bool IsNoReturnThumb
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsNoOffsetThumb
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void LateUpdate()
	{
	}

	private void InitCameraLookAt()
	{
	}

	protected override void UpdateControlState()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnUp(bool real = true)
	{
	}

	protected override void DoActionBeforeEndOfFrame()
	{
	}

	private void UpdateJoystick()
	{
	}

	private bool isTouchOverJoystickArea(ref Vector2 localPosition, ref Vector2 screenPosition)
	{
		return false;
	}

	private bool isScreenPointOverArea(Vector2 screenPosition, ref Vector2 localPosition)
	{
		return false;
	}

	private int GetTouchCount()
	{
		return 0;
	}

	public float GetRadius()
	{
		return 0f;
	}

	protected override void SetActivated()
	{
	}

	protected override void SetVisible(bool visible = true)
	{
	}

	private void DoTurnAndMove()
	{
	}

	public void InitCurve()
	{
	}

	public void InitTurnMoveCurve()
	{
	}
}
