using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ETCButton : ETCBase, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	[Serializable]
	public class OnDownHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressedHandler : UnityEvent
	{
	}

	[Serializable]
	public class OnPressedValueandler : UnityEvent<float>
	{
	}

	[Serializable]
	public class OnUPHandler : UnityEvent
	{
	}

	[SerializeField]
	public OnDownHandler onDown;

	[SerializeField]
	public OnPressedHandler onPressed;

	[SerializeField]
	public OnPressedValueandler onPressedValue;

	[SerializeField]
	public OnUPHandler onUp;

	public ETCAxis axis;

	public Sprite normalSprite;

	public Color normalColor;

	public Sprite pressedSprite;

	public Color pressedColor;

	private Image cachedImage;

	private bool isOnPress;

	private GameObject previousDargObject;

	private bool isOnTouch;

	protected override void Awake()
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

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void UpdateButton()
	{
	}

	protected override void SetVisible(bool forceUnvisible = false)
	{
	}

	private void ApllyState()
	{
	}

	protected override void SetActivated()
	{
	}
}
