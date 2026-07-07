using System;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	[AddComponentMenu("EasyTouch/Quick Drag")]
	public class QuickDrag : QuickBase
	{
		[Serializable]
		public class OnDragStart : UnityEvent<Gesture>
		{
		}

		[Serializable]
		public class OnDrag : UnityEvent<Gesture>
		{
		}

		[Serializable]
		public class OnDragEnd : UnityEvent<Gesture>
		{
		}

		[SerializeField]
		public OnDragStart onDragStart;

		[SerializeField]
		public OnDrag onDrag;

		[SerializeField]
		public OnDragEnd onDragEnd;

		public bool isStopOncollisionEnter;

		private Vector3 deltaPosition;

		private bool isOnDrag;

		private Gesture lastGesture;

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

		private void OnCollisionEnter()
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

		private void On_DragStart(Gesture gesture)
		{
		}

		private void On_Drag(Gesture gesture)
		{
		}

		private void On_DragEnd(Gesture gesture)
		{
		}

		private Vector3 GetPositionAxes(Vector3 position)
		{
			return default(Vector3);
		}

		public void StopDrag()
		{
		}
	}
}
