using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Swipe")]
	public class QuickSwipe : QuickBase
	{
		[Serializable]
		public class OnSwipeAction : UnityEvent<Gesture>
		{
		}

		public enum ActionTriggering
		{
			InProgress = 0,
			End = 1
		}

		public enum SwipeDirection
		{
			Vertical = 0,
			Horizontal = 1,
			DiagonalRight = 2,
			DiagonalLeft = 3,
			Up = 4,
			UpRight = 5,
			Right = 6,
			DownRight = 7,
			Down = 8,
			DownLeft = 9,
			Left = 10,
			UpLeft = 11,
			All = 12
		}

		[SerializeField]
		public OnSwipeAction onSwipeAction;

		public bool allowSwipeStartOverMe;

		public ActionTriggering actionTriggering;

		public SwipeDirection swipeDirection;

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

		private void On_Swipe(Gesture gesture)
		{
		}

		private void On_SwipeEnd(Gesture gesture)
		{
		}

		private void On_DragEnd(Gesture gesture)
		{
		}

		private void On_Drag(Gesture gesture)
		{
		}

		private bool isRightDirection(Gesture gesture)
		{
			return false;
		}

		private void DoAction(Gesture gesture)
		{
		}
	}
}
