using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick LongTap")]
	public class QuickLongTap : QuickBase
	{
		[Serializable]
		public class OnLongTap : UnityEvent<Gesture>
		{
		}

		public enum ActionTriggering
		{
			Start = 0,
			InProgress = 1,
			End = 2
		}

		[SerializeField]
		public OnLongTap onLongTap;

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
