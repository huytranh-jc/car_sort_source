using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Touch")]
	public class QuickTouch : QuickBase
	{
		[Serializable]
		public class OnTouch : UnityEvent<Gesture>
		{
		}

		[Serializable]
		public class OnTouchNotOverMe : UnityEvent<Gesture>
		{
		}

		public enum ActionTriggering
		{
			Start = 0,
			Down = 1,
			Up = 2
		}

		[SerializeField]
		public OnTouch onTouch;

		public OnTouchNotOverMe onTouchNotOverMe;

		public ActionTriggering actionTriggering;

		private Gesture currentGesture;

		private void Update()
		{
		}

		private void DoAction(Gesture gesture)
		{
		}

		private bool IsOverMe(Gesture gesture)
		{
			return false;
		}
	}
}
