using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	public class BaseFinger
	{
		public int fingerIndex;

		public int touchCount;

		public Vector2 startPosition;

		public Vector2 position;

		public Vector2 deltaPosition;

		public float actionTime;

		public float deltaTime;

		public Camera pickedCamera;

		public GameObject pickedObject;

		public bool isGuiCamera;

		public bool isOverGui;

		public GameObject pickedUIElement;

		public float altitudeAngle;

		public float azimuthAngle;

		public float maximumPossiblePressure;

		public float pressure;

		public float radius;

		public float radiusVariance;

		public TouchType touchType;

		public Gesture GetGesture()
		{
			return null;
		}
	}
}
