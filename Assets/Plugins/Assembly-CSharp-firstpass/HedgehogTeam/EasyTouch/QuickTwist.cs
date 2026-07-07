using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Twist")]
	public class QuickTwist : QuickBase
	{
		[Serializable]
		public class OnTwistAction : UnityEvent<Gesture>
		{
		}

		public enum ActionTiggering
		{
			InProgress = 0,
			End = 1
		}

		public enum ActionRotationDirection
		{
			All = 0,
			Clockwise = 1,
			Counterclockwise = 2
		}

		[SerializeField]
		public OnTwistAction onTwistAction;

		public bool isGestureOnMe;

		public ActionTiggering actionTriggering;

		public ActionRotationDirection rotationDirection;

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

		private void On_Twist(Gesture gesture)
		{
		}

		private void On_TwistEnd(Gesture gesture)
		{
		}

		private bool IsRightRotation(Gesture gesture)
		{
			return false;
		}

		private void DoAction(Gesture gesture)
		{
		}
	}
}
