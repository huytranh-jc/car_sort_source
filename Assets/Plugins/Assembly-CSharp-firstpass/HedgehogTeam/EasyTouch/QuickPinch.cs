using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Pinch")]
	public class QuickPinch : QuickBase
	{
		[Serializable]
		public class OnPinchAction : UnityEvent<Gesture>
		{
		}

		public enum ActionTiggering
		{
			InProgress = 0,
			End = 1
		}

		public enum ActionPinchDirection
		{
			All = 0,
			PinchIn = 1,
			PinchOut = 2
		}

		[SerializeField]
		public OnPinchAction onPinchAction;

		public bool isGestureOnMe;

		public ActionTiggering actionTriggering;

		public ActionPinchDirection pinchDirection;

		private float axisActionValue;

		public bool enableSimpleAction;

		public override void OnEnable()
		{
		}

		public override void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void UnsubscribeEvent()
		{
		}

		private void On_Pinch(Gesture gesture)
		{
		}

		private void On_PinchIn(Gesture gesture)
		{
		}

		private void On_PinchOut(Gesture gesture)
		{
		}

		private void On_PichEnd(Gesture gesture)
		{
		}

		private void DoAction(Gesture gesture)
		{
		}
	}
}
