using System;
using UnityEngine;

[Serializable]
public class ETCAxis
{
	public enum DirectAction
	{
		Rotate = 0,
		RotateLocal = 1,
		Translate = 2,
		TranslateLocal = 3,
		Scale = 4,
		Force = 5,
		RelativeForce = 6,
		Torque = 7,
		RelativeTorque = 8,
		Jump = 9
	}

	public enum AxisInfluenced
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum AxisValueMethod
	{
		Classical = 0,
		Curve = 1
	}

	public enum AxisState
	{
		None = 0,
		Down = 1,
		Press = 2,
		Up = 3,
		DownUp = 4,
		DownDown = 5,
		DownLeft = 6,
		DownRight = 7,
		PressUp = 8,
		PressDown = 9,
		PressLeft = 10,
		PressRight = 11
	}

	public enum ActionOn
	{
		Down = 0,
		Press = 1
	}

	public string name;

	public bool autoLinkTagPlayer;

	public string autoTag;

	public GameObject player;

	public bool enable;

	public bool invertedAxis;

	public float speed;

	public float deadValue;

	public AxisValueMethod valueMethod;

	public AnimationCurve curveValue;

	public bool isEnertia;

	public float inertia;

	public float inertiaThreshold;

	public bool isAutoStab;

	public float autoStabThreshold;

	public float autoStabSpeed;

	private float startAngle;

	public bool isClampRotation;

	public float maxAngle;

	public float minAngle;

	public bool isValueOverTime;

	public float overTimeStep;

	public float maxOverTimeValue;

	public float axisValue;

	public float axisSpeedValue;

	public float axisThreshold;

	public bool isLockinJump;

	private Vector3 lastMove;

	public AxisState axisState;

	[SerializeField]
	private Transform _directTransform;

	public DirectAction directAction;

	public AxisInfluenced axisInfluenced;

	public ActionOn actionOn;

	public CharacterController directCharacterController;

	public Rigidbody directRigidBody;

	public float gravity;

	public float currentGravity;

	public bool isJump;

	public string unityAxis;

	public bool showGeneralInspector;

	public bool showDirectInspector;

	public bool showInertiaInspector;

	public bool showSimulatinInspector;

	public Transform directTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ETCAxis(string axisName)
	{
	}

	public void InitAxis()
	{
	}

	public void UpdateAxis(float realValue, bool isOnDrag, ETCBase.ControlType type, bool deltaTime = true)
	{
	}

	public void UpdateButton()
	{
	}

	public void ResetAxis()
	{
	}

	public void DoDirectAction()
	{
	}

	public void DoGravity()
	{
	}

	private void ComputAxisValue(float realValue, ETCBase.ControlType type, bool isOnDrag, bool deltaTime)
	{
	}

	private Vector3 GetInfluencedAxis()
	{
		return default(Vector3);
	}

	private float GetAngle()
	{
		return 0f;
	}

	private void DoAutoStabilisation()
	{
	}

	private void DoAngleLimitation()
	{
	}

	public void InitDeadCurve()
	{
	}
}
