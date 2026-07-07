using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	public class QuickBase : MonoBehaviour
	{
		protected enum GameObjectType
		{
			Auto = 0,
			Obj_3D = 1,
			Obj_2D = 2,
			UI = 3
		}

		public enum DirectAction
		{
			None = 0,
			Rotate = 1,
			RotateLocal = 2,
			Translate = 3,
			TranslateLocal = 4,
			Scale = 5
		}

		public enum AffectedAxesAction
		{
			X = 0,
			Y = 1,
			Z = 2,
			XY = 3,
			XZ = 4,
			YZ = 5,
			XYZ = 6
		}

		public string quickActionName;

		public bool isMultiTouch;

		public bool is2Finger;

		public bool isOnTouch;

		public bool enablePickOverUI;

		public bool resetPhysic;

		public DirectAction directAction;

		public AffectedAxesAction axesAction;

		public float sensibility;

		public CharacterController directCharacterController;

		public bool inverseAxisValue;

		protected Rigidbody cachedRigidBody;

		protected bool isKinematic;

		protected Rigidbody2D cachedRigidBody2D;

		protected bool isKinematic2D;

		protected GameObjectType realType;

		protected int fingerIndex;

		private void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		protected Vector3 GetInfluencedAxis()
		{
			return default(Vector3);
		}

		protected void DoDirectAction(float value)
		{
		}

		public void EnabledQuickComponent(string quickActionName)
		{
		}

		public void DisabledQuickComponent(string quickActionName)
		{
		}

		public void DisabledAllSwipeExcepted(string quickActionName)
		{
		}
	}
}
