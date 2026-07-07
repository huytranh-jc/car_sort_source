using System;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	public class Gesture : BaseFinger, ICloneable
	{
		public EasyTouch.SwipeDirection swipe;

		public float swipeLength;

		public Vector2 swipeVector;

		public float deltaPinch;

		public float twistAngle;

		public float twoFingerDistance;

		public EasyTouch.EvtType type;

		public object Clone()
		{
			return null;
		}

		public Vector3 GetTouchToWorldPoint(float z)
		{
			return default(Vector3);
		}

		public Vector3 GetTouchToWorldPoint(Vector3 position3D)
		{
			return default(Vector3);
		}

		public float GetSwipeOrDragAngle()
		{
			return 0f;
		}

		public Vector2 NormalizedPosition()
		{
			return default(Vector2);
		}

		public bool IsOverUIElement()
		{
			return false;
		}

		public bool IsOverRectTransform(RectTransform tr, Camera camera = null)
		{
			return false;
		}

		public GameObject GetCurrentFirstPickedUIElement(bool isTwoFinger = false)
		{
			return null;
		}

		public GameObject GetCurrentPickedObject(bool isTwoFinger = false)
		{
			return null;
		}
	}
}
