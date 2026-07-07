using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Enter-Over-Exit")]
	public class QuickEnterOverExist : QuickBase
	{
		[Serializable]
		public class OnTouchEnter : UnityEvent<Gesture>
		{
		}

		[Serializable]
		public class OnTouchOver : UnityEvent<Gesture>
		{
		}

		[Serializable]
		public class OnTouchExit : UnityEvent<Gesture>
		{
		}

		[SerializeField]
		public OnTouchEnter onTouchEnter;

		[SerializeField]
		public OnTouchOver onTouchOver;

		[SerializeField]
		public OnTouchExit onTouchExit;

		private bool[] fingerOver;

		private void Awake()
		{
		}

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

		private void On_TouchDown(Gesture gesture)
		{
		}

		private void On_TouchUp(Gesture gesture)
		{
		}
	}
}
