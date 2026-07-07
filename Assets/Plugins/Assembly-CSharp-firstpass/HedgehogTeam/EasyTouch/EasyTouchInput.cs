using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	public class EasyTouchInput
	{
		private Vector2[] oldMousePosition;

		private int[] tapCount;

		private float[] startActionTime;

		private float[] deltaTime;

		private float[] tapeTime;

		private bool bComplex;

		private Vector2 deltaFingerPosition;

		private Vector2 oldFinger2Position;

		private Vector2 complexCenter;

		public int TouchCount()
		{
			return 0;
		}

		private int getTouchCount(bool realTouch)
		{
			return 0;
		}

		public Finger GetMouseTouch(int fingerIndex, Finger myFinger)
		{
			return null;
		}

		public Vector2 GetSecondFingerPosition()
		{
			return default(Vector2);
		}

		private Vector2 GetPointerPosition(int index)
		{
			return default(Vector2);
		}

		private Vector2 GetPinchTwist2Finger(bool newSim = false)
		{
			return default(Vector2);
		}

		private Vector2 GetComplex2finger()
		{
			return default(Vector2);
		}
	}
}
