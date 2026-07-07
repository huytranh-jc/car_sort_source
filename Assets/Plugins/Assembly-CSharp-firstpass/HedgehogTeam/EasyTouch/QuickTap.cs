using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Tap")]
	public class QuickTap : QuickBase
	{
		[Serializable]
		public class OnTap : UnityEvent<Gesture>
		{
		}

		public enum ActionTriggering
		{
			Simple_Tap = 0,
			Double_Tap = 1
		}

		[SerializeField]
		public OnTap onTap;

		public ActionTriggering actionTriggering;

		private Gesture currentGesture;

		private void Update()
		{
		}

		private void DoAction(Gesture gesture)
		{
		}
	}
}
