using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public abstract class ETCBase : MonoBehaviour
{
	public enum ControlType
	{
		Joystick = 0,
		TouchPad = 1,
		DPad = 2,
		Button = 3
	}

	public enum RectAnchor
	{
		UserDefined = 0,
		BottomLeft = 1,
		BottomCenter = 2,
		BottonRight = 3,
		CenterLeft = 4,
		Center = 5,
		CenterRight = 6,
		TopLeft = 7,
		TopCenter = 8,
		TopRight = 9
	}

	public enum DPadAxis
	{
		Two_Axis = 0,
		Four_Axis = 1
	}

	public enum CameraMode
	{
		Follow = 0,
		SmoothFollow = 1
	}

	public enum CameraTargetMode
	{
		UserDefined = 0,
		LinkOnTag = 1,
		FromDirectActionAxisX = 2,
		FromDirectActionAxisY = 3
	}

	[CompilerGenerated]
	private sealed class _003CFixedUpdateVirtualControl_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ETCBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFixedUpdateVirtualControl_003Ed__79(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateVirtualControl_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ETCBase _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateVirtualControl_003Ed__78(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	protected RectTransform cachedRectTransform;

	protected Canvas cachedRootCanvas;

	public bool isUnregisterAtDisable;

	private bool visibleAtStart;

	private bool activatedAtStart;

	[SerializeField]
	protected RectAnchor _anchor;

	[SerializeField]
	protected Vector2 _anchorOffet;

	[SerializeField]
	protected bool _visible;

	[SerializeField]
	protected bool _activated;

	public bool enableCamera;

	public CameraMode cameraMode;

	public string camTargetTag;

	public bool autoLinkTagCam;

	public string autoCamTag;

	public Transform cameraTransform;

	public CameraTargetMode cameraTargetMode;

	public bool enableWallDetection;

	public LayerMask wallLayer;

	public Transform cameraLookAt;

	protected CharacterController cameraLookAtCC;

	public Vector3 followOffset;

	public float followDistance;

	public float followHeight;

	public float followRotationDamping;

	public float followHeightDamping;

	public int pointId;

	public bool enableKeySimulation;

	public bool allowSimulationStandalone;

	public bool visibleOnStandalone;

	public DPadAxis dPadAxisCount;

	public bool useFixedUpdate;

	private List<RaycastResult> uiRaycastResultCache;

	private PointerEventData uiPointerEventData;

	private EventSystem uiEventSystem;

	public bool isOnDrag;

	public bool isSwipeIn;

	public bool isSwipeOut;

	public bool showPSInspector;

	public bool showSpriteInspector;

	public bool showEventInspector;

	public bool showBehaviourInspector;

	public bool showAxesInspector;

	public bool showTouchEventInspector;

	public bool showDownEventInspector;

	public bool showPressEventInspector;

	public bool showCameraInspector;

	public RectAnchor anchor
	{
		get
		{
			return default(RectAnchor);
		}
		set
		{
		}
	}

	public Vector2 anchorOffet
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool activated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual void Awake()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void FixedUpdate()
	{
	}

	public virtual void LateUpdate()
	{
	}

	protected virtual void UpdateControlState()
	{
	}

	protected virtual void SetVisible(bool forceUnvisible = true)
	{
	}

	protected virtual void SetActivated()
	{
	}

	public void SetAnchorPosition()
	{
	}

	protected GameObject GetFirstUIElement(Vector2 position)
	{
		return null;
	}

	protected void CameraSmoothFollow()
	{
	}

	protected void CameraFollow()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateVirtualControl_003Ed__78))]
	private IEnumerator UpdateVirtualControl()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFixedUpdateVirtualControl_003Ed__79))]
	private IEnumerator FixedUpdateVirtualControl()
	{
		return null;
	}

	protected virtual void DoActionBeforeEndOfFrame()
	{
	}
}
