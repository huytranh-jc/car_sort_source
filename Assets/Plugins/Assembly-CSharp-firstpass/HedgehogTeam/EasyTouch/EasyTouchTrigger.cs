using System;
using System.Collections.Generic;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	[Serializable]
	[AddComponentMenu("EasyTouch/Trigger")]
	public class EasyTouchTrigger : MonoBehaviour
	{
		public enum ETTParameter
		{
			None = 0,
			Gesture = 1,
			Finger_Id = 2,
			Touch_Count = 3,
			Start_Position = 4,
			Position = 5,
			Delta_Position = 6,
			Swipe_Type = 7,
			Swipe_Length = 8,
			Swipe_Vector = 9,
			Delta_Pinch = 10,
			Twist_Anlge = 11,
			ActionTime = 12,
			DeltaTime = 13,
			PickedObject = 14,
			PickedUIElement = 15
		}

		public enum ETTType
		{
			Object3D = 0,
			UI = 1
		}

		[Serializable]
		public class EasyTouchReceiver
		{
			public bool enable;

			public ETTType triggerType;

			public string name;

			public bool restricted;

			public GameObject gameObject;

			public bool otherReceiver;

			public GameObject gameObjectReceiver;

			public EasyTouch.EvtType eventName;

			public string methodName;

			public ETTParameter parameter;
		}

		[SerializeField]
		public List<EasyTouchReceiver> receivers;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SubscribeEasyTouchEvent()
		{
		}

		private void UnsubscribeEasyTouchEvent()
		{
		}

		private void On_TouchStart(Gesture gesture)
		{
		}

		private void On_TouchDown(Gesture gesture)
		{
		}

		private void On_TouchUp(Gesture gesture)
		{
		}

		private void On_SimpleTap(Gesture gesture)
		{
		}

		private void On_DoubleTap(Gesture gesture)
		{
		}

		private void On_LongTapStart(Gesture gesture)
		{
		}

		private void On_LongTap(Gesture gesture)
		{
		}

		private void On_LongTapEnd(Gesture gesture)
		{
		}

		private void On_SwipeStart(Gesture gesture)
		{
		}

		private void On_Swipe(Gesture gesture)
		{
		}

		private void On_SwipeEnd(Gesture gesture)
		{
		}

		private void On_DragStart(Gesture gesture)
		{
		}

		private void On_Drag(Gesture gesture)
		{
		}

		private void On_DragEnd(Gesture gesture)
		{
		}

		private void On_Cancel(Gesture gesture)
		{
		}

		private void On_TouchStart2Fingers(Gesture gesture)
		{
		}

		private void On_TouchDown2Fingers(Gesture gesture)
		{
		}

		private void On_TouchUp2Fingers(Gesture gesture)
		{
		}

		private void On_LongTapStart2Fingers(Gesture gesture)
		{
		}

		private void On_LongTap2Fingers(Gesture gesture)
		{
		}

		private void On_LongTapEnd2Fingers(Gesture gesture)
		{
		}

		private void On_DragStart2Fingers(Gesture gesture)
		{
		}

		private void On_Drag2Fingers(Gesture gesture)
		{
		}

		private void On_DragEnd2Fingers(Gesture gesture)
		{
		}

		private void On_SwipeStart2Fingers(Gesture gesture)
		{
		}

		private void On_Swipe2Fingers(Gesture gesture)
		{
		}

		private void On_SwipeEnd2Fingers(Gesture gesture)
		{
		}

		private void On_Twist(Gesture gesture)
		{
		}

		private void On_TwistEnd(Gesture gesture)
		{
		}

		private void On_Pinch(Gesture gesture)
		{
		}

		private void On_PinchOut(Gesture gesture)
		{
		}

		private void On_PinchIn(Gesture gesture)
		{
		}

		private void On_PinchEnd(Gesture gesture)
		{
		}

		private void On_SimpleTap2Fingers(Gesture gesture)
		{
		}

		private void On_DoubleTap2Fingers(Gesture gesture)
		{
		}

		private void On_UIElementTouchUp(Gesture gesture)
		{
		}

		private void On_OverUIElement(Gesture gesture)
		{
		}

		public void AddTrigger(EasyTouch.EvtType ev)
		{
		}

		public bool SetTriggerEnable(string triggerName, bool value)
		{
			return false;
		}

		public bool GetTriggerEnable(string triggerName)
		{
			return false;
		}

		private void TriggerScheduler(EasyTouch.EvtType evnt, Gesture gesture)
		{
		}

		private bool IsRecevier4(EasyTouch.EvtType evnt)
		{
			return false;
		}

		private EasyTouchReceiver GetTrigger(string triggerName)
		{
			return null;
		}
	}
}
