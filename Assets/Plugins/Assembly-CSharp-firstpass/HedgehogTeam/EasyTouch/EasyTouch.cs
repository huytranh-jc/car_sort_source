using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HedgehogTeam.EasyTouch
{
	public class EasyTouch : MonoBehaviour
	{
		[Serializable]
		private class DoubleTap
		{
			public bool inDoubleTap;

			public bool inWait;

			public float time;

			public int count;

			public Finger finger;

			public void Stop()
			{
			}
		}

		private class PickedObject
		{
			public GameObject pickedObj;

			public Camera pickedCamera;

			public bool isGUI;
		}

		public delegate void TouchCancelHandler(Gesture gesture);

		public delegate void Cancel2FingersHandler(Gesture gesture);

		public delegate void TouchStartHandler(Gesture gesture);

		public delegate void TouchDownHandler(Gesture gesture);

		public delegate void TouchUpHandler(Gesture gesture);

		public delegate void SimpleTapHandler(Gesture gesture);

		public delegate void DoubleTapHandler(Gesture gesture);

		public delegate void LongTapStartHandler(Gesture gesture);

		public delegate void LongTapHandler(Gesture gesture);

		public delegate void LongTapEndHandler(Gesture gesture);

		public delegate void DragStartHandler(Gesture gesture);

		public delegate void DragHandler(Gesture gesture);

		public delegate void DragEndHandler(Gesture gesture);

		public delegate void SwipeStartHandler(Gesture gesture);

		public delegate void SwipeHandler(Gesture gesture);

		public delegate void SwipeEndHandler(Gesture gesture);

		public delegate void TouchStart2FingersHandler(Gesture gesture);

		public delegate void TouchDown2FingersHandler(Gesture gesture);

		public delegate void TouchUp2FingersHandler(Gesture gesture);

		public delegate void SimpleTap2FingersHandler(Gesture gesture);

		public delegate void DoubleTap2FingersHandler(Gesture gesture);

		public delegate void LongTapStart2FingersHandler(Gesture gesture);

		public delegate void LongTap2FingersHandler(Gesture gesture);

		public delegate void LongTapEnd2FingersHandler(Gesture gesture);

		public delegate void TwistHandler(Gesture gesture);

		public delegate void TwistEndHandler(Gesture gesture);

		public delegate void PinchInHandler(Gesture gesture);

		public delegate void PinchOutHandler(Gesture gesture);

		public delegate void PinchEndHandler(Gesture gesture);

		public delegate void PinchHandler(Gesture gesture);

		public delegate void DragStart2FingersHandler(Gesture gesture);

		public delegate void Drag2FingersHandler(Gesture gesture);

		public delegate void DragEnd2FingersHandler(Gesture gesture);

		public delegate void SwipeStart2FingersHandler(Gesture gesture);

		public delegate void Swipe2FingersHandler(Gesture gesture);

		public delegate void SwipeEnd2FingersHandler(Gesture gesture);

		public delegate void EasyTouchIsReadyHandler();

		public delegate void OverUIElementHandler(Gesture gesture);

		public delegate void UIElementTouchUpHandler(Gesture gesture);

		public enum GesturePriority
		{
			Tap = 0,
			Slips = 1
		}

		public enum DoubleTapDetection
		{
			BySystem = 0,
			ByTime = 1
		}

		public enum GestureType
		{
			Tap = 0,
			Drag = 1,
			Swipe = 2,
			None = 3,
			LongTap = 4,
			Pinch = 5,
			Twist = 6,
			Cancel = 7,
			Acquisition = 8
		}

		public enum SwipeDirection
		{
			None = 0,
			Left = 1,
			Right = 2,
			Up = 3,
			Down = 4,
			UpLeft = 5,
			UpRight = 6,
			DownLeft = 7,
			DownRight = 8,
			Other = 9,
			All = 10
		}

		public enum TwoFingerPickMethod
		{
			Finger = 0,
			Average = 1
		}

		public enum EvtType
		{
			None = 0,
			On_TouchStart = 1,
			On_TouchDown = 2,
			On_TouchUp = 3,
			On_SimpleTap = 4,
			On_DoubleTap = 5,
			On_LongTapStart = 6,
			On_LongTap = 7,
			On_LongTapEnd = 8,
			On_DragStart = 9,
			On_Drag = 10,
			On_DragEnd = 11,
			On_SwipeStart = 12,
			On_Swipe = 13,
			On_SwipeEnd = 14,
			On_TouchStart2Fingers = 15,
			On_TouchDown2Fingers = 16,
			On_TouchUp2Fingers = 17,
			On_SimpleTap2Fingers = 18,
			On_DoubleTap2Fingers = 19,
			On_LongTapStart2Fingers = 20,
			On_LongTap2Fingers = 21,
			On_LongTapEnd2Fingers = 22,
			On_Twist = 23,
			On_TwistEnd = 24,
			On_Pinch = 25,
			On_PinchIn = 26,
			On_PinchOut = 27,
			On_PinchEnd = 28,
			On_DragStart2Fingers = 29,
			On_Drag2Fingers = 30,
			On_DragEnd2Fingers = 31,
			On_SwipeStart2Fingers = 32,
			On_Swipe2Fingers = 33,
			On_SwipeEnd2Fingers = 34,
			On_EasyTouchIsReady = 35,
			On_Cancel = 36,
			On_Cancel2Fingers = 37,
			On_OverUIElement = 38,
			On_UIElementTouchUp = 39
		}

		[CompilerGenerated]
		private sealed class _003CSingleOrDouble2Fingers_003Ed__235 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EasyTouch _003C_003E4__this;

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
			public _003CSingleOrDouble2Fingers_003Ed__235(int _003C_003E1__state)
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
		private sealed class _003CSingleOrDouble_003Ed__229 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EasyTouch _003C_003E4__this;

			public int fingerIndex;

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
			public _003CSingleOrDouble_003Ed__229(int _003C_003E1__state)
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

		private static EasyTouch _instance;

		private Gesture _currentGesture;

		private List<Gesture> _currentGestures;

		public bool enable;

		public bool enableRemote;

		public GesturePriority gesturePriority;

		public float StationaryTolerance;

		public float longTapTime;

		public float swipeTolerance;

		public float minPinchLength;

		public float minTwistAngle;

		public DoubleTapDetection doubleTapDetection;

		public float doubleTapTime;

		public bool alwaysSendSwipe;

		public bool enable2FingersGesture;

		public bool enableTwist;

		public bool enablePinch;

		public bool enable2FingersSwipe;

		public TwoFingerPickMethod twoFingerPickMethod;

		public List<ECamera> touchCameras;

		public bool autoSelect;

		public LayerMask pickableLayers3D;

		public bool enable2D;

		public LayerMask pickableLayers2D;

		public bool autoUpdatePickedObject;

		public bool allowUIDetection;

		public bool enableUIMode;

		public bool autoUpdatePickedUI;

		public bool enabledNGuiMode;

		public LayerMask nGUILayers;

		public List<Camera> nGUICameras;

		public bool enableSimulation;

		public KeyCode twistKey;

		public KeyCode swipeKey;

		public bool showGuiInspector;

		public bool showSelectInspector;

		public bool showGestureInspector;

		public bool showTwoFingerInspector;

		public bool showSecondFingerInspector;

		private EasyTouchInput input;

		private Finger[] fingers;

		public Texture secondFingerTexture;

		private TwoFingerGesture twoFinger;

		private int oldTouchCount;

		private DoubleTap[] singleDoubleTap;

		private Finger[] tmpArray;

		private PickedObject pickedObject;

		private List<RaycastResult> uiRaycastResultCache;

		private PointerEventData uiPointerEventData;

		private EventSystem uiEventSystem;

		public static EasyTouch instance => null;

		public static Gesture current => null;

		public static event TouchCancelHandler On_Cancel
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Cancel2FingersHandler On_Cancel2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchStartHandler On_TouchStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchDownHandler On_TouchDown
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchUpHandler On_TouchUp
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SimpleTapHandler On_SimpleTap
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DoubleTapHandler On_DoubleTap
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTapStartHandler On_LongTapStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTapHandler On_LongTap
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTapEndHandler On_LongTapEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DragStartHandler On_DragStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DragHandler On_Drag
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DragEndHandler On_DragEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SwipeStartHandler On_SwipeStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SwipeHandler On_Swipe
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SwipeEndHandler On_SwipeEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchStart2FingersHandler On_TouchStart2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchDown2FingersHandler On_TouchDown2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TouchUp2FingersHandler On_TouchUp2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SimpleTap2FingersHandler On_SimpleTap2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DoubleTap2FingersHandler On_DoubleTap2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTapStart2FingersHandler On_LongTapStart2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTap2FingersHandler On_LongTap2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LongTapEnd2FingersHandler On_LongTapEnd2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TwistHandler On_Twist
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event TwistEndHandler On_TwistEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PinchHandler On_Pinch
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PinchInHandler On_PinchIn
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PinchOutHandler On_PinchOut
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PinchEndHandler On_PinchEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DragStart2FingersHandler On_DragStart2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Drag2FingersHandler On_Drag2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event DragEnd2FingersHandler On_DragEnd2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SwipeStart2FingersHandler On_SwipeStart2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Swipe2FingersHandler On_Swipe2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SwipeEnd2FingersHandler On_SwipeEnd2Fingers
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event EasyTouchIsReadyHandler On_EasyTouchIsReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OverUIElementHandler On_OverUIElement
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event UIElementTouchUpHandler On_UIElementTouchUp
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Init()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateTouches(bool realTouch, int touchCount)
		{
		}

		private void ResetTouches()
		{
		}

		private void OneFinger(int fingerIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CSingleOrDouble_003Ed__229))]
		private IEnumerator SingleOrDouble(int fingerIndex)
		{
			return null;
		}

		private void CreateGesture(int touchIndex, EvtType message, Finger finger, SwipeDirection swipe, float swipeLength, Vector2 swipeVector)
		{
		}

		private void TwoFinger()
		{
		}

		private void DetectPinch(float currentDelta)
		{
		}

		private void DetecTwist(Vector2 previousDistance, Vector2 currentDistance, float currentDelta)
		{
		}

		private void CreateStateEnd2Fingers(GestureType gesture, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float time, bool realEnd, float fingerDistance, float twist = 0f, float pinch = 0f)
		{
		}

		[IteratorStateMachine(typeof(_003CSingleOrDouble2Fingers_003Ed__235))]
		private IEnumerator SingleOrDouble2Fingers()
		{
			return null;
		}

		private void CreateGesture2Finger(EvtType message, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float actionTime, SwipeDirection swipe, float swipeLength, Vector2 swipeVector, float twist, float pinch, float twoDistance)
		{
		}

		private int GetTwoFinger(int index)
		{
			return 0;
		}

		private bool GetTwoFingerPickedObject()
		{
			return false;
		}

		private bool GetTwoFingerPickedUIElement()
		{
			return false;
		}

		private void RaiseEvent(EvtType evnt, Gesture gesture)
		{
		}

		private bool GetPickedGameObject(Finger finger, bool isTowFinger = false)
		{
			return false;
		}

		private bool GetGameObjectAt(Vector2 position, Camera cam, bool isGuiCam)
		{
			return false;
		}

		private SwipeDirection GetSwipe(Vector2 start, Vector2 end)
		{
			return default(SwipeDirection);
		}

		private bool FingerInTolerance(Finger finger)
		{
			return false;
		}

		private bool IsTouchOverNGui(Vector2 position, bool isTwoFingers = false)
		{
			return false;
		}

		private Finger GetFinger(int finderId)
		{
			return null;
		}

		private bool IsScreenPositionOverUI(Vector2 position)
		{
			return false;
		}

		private GameObject GetFirstUIElementFromCache()
		{
			return null;
		}

		private GameObject GetFirstUIElement(Vector2 position)
		{
			return null;
		}

		public static bool IsFingerOverUIElement(int fingerIndex)
		{
			return false;
		}

		public static GameObject GetCurrentPickedUIElement(int fingerIndex, bool isTwoFinger)
		{
			return null;
		}

		public static GameObject GetCurrentPickedObject(int fingerIndex, bool isTwoFinger)
		{
			return null;
		}

		public static GameObject GetGameObjectAt(Vector2 position, bool isTwoFinger = false)
		{
			return null;
		}

		public static int GetTouchCount()
		{
			return 0;
		}

		public static void ResetTouch(int fingerIndex)
		{
		}

		public static void SetEnabled(bool enable)
		{
		}

		public static bool GetEnabled()
		{
			return false;
		}

		public static void SetEnableUIDetection(bool enable)
		{
		}

		public static bool GetEnableUIDetection()
		{
			return false;
		}

		public static void SetUICompatibily(bool value)
		{
		}

		public static bool GetUIComptability()
		{
			return false;
		}

		public static void SetAutoUpdateUI(bool value)
		{
		}

		public static bool GetAutoUpdateUI()
		{
			return false;
		}

		public static void SetNGUICompatibility(bool value)
		{
		}

		public static bool GetNGUICompatibility()
		{
			return false;
		}

		public static void SetEnableAutoSelect(bool value)
		{
		}

		public static bool GetEnableAutoSelect()
		{
			return false;
		}

		public static void SetAutoUpdatePickedObject(bool value)
		{
		}

		public static bool GetAutoUpdatePickedObject()
		{
			return false;
		}

		public static void Set3DPickableLayer(LayerMask mask)
		{
		}

		public static LayerMask Get3DPickableLayer()
		{
			return default(LayerMask);
		}

		public static void AddCamera(Camera cam, bool guiCam = false)
		{
		}

		public static void RemoveCamera(Camera cam)
		{
		}

		public static Camera GetCamera(int index = 0)
		{
			return null;
		}

		public static void SetEnable2DCollider(bool value)
		{
		}

		public static bool GetEnable2DCollider()
		{
			return false;
		}

		public static void Set2DPickableLayer(LayerMask mask)
		{
		}

		public static LayerMask Get2DPickableLayer()
		{
			return default(LayerMask);
		}

		public static void SetGesturePriority(GesturePriority value)
		{
		}

		public static GesturePriority GetGesturePriority()
		{
			return default(GesturePriority);
		}

		public static void SetStationaryTolerance(float tolerance)
		{
		}

		public static float GetStationaryTolerance()
		{
			return 0f;
		}

		public static void SetLongTapTime(float time)
		{
		}

		public static float GetlongTapTime()
		{
			return 0f;
		}

		public static void SetDoubleTapTime(float time)
		{
		}

		public static float GetDoubleTapTime()
		{
			return 0f;
		}

		public static void SetDoubleTapMethod(DoubleTapDetection detection)
		{
		}

		public static DoubleTapDetection GetDoubleTapMethod()
		{
			return default(DoubleTapDetection);
		}

		public static void SetSwipeTolerance(float tolerance)
		{
		}

		public static float GetSwipeTolerance()
		{
			return 0f;
		}

		public static void SetEnable2FingersGesture(bool enable)
		{
		}

		public static bool GetEnable2FingersGesture()
		{
			return false;
		}

		public static void SetTwoFingerPickMethod(TwoFingerPickMethod pickMethod)
		{
		}

		public static TwoFingerPickMethod GetTwoFingerPickMethod()
		{
			return default(TwoFingerPickMethod);
		}

		public static void SetEnablePinch(bool enable)
		{
		}

		public static bool GetEnablePinch()
		{
			return false;
		}

		public static void SetMinPinchLength(float length)
		{
		}

		public static float GetMinPinchLength()
		{
			return 0f;
		}

		public static void SetEnableTwist(bool enable)
		{
		}

		public static bool GetEnableTwist()
		{
			return false;
		}

		public static void SetMinTwistAngle(float angle)
		{
		}

		public static float GetMinTwistAngle()
		{
			return 0f;
		}

		public static bool GetSecondeFingerSimulation()
		{
			return false;
		}

		public static void SetSecondFingerSimulation(bool value)
		{
		}
	}
}
