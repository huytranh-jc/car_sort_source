using System.Collections.Generic;
using UnityEngine;

public class ETCInput : MonoBehaviour
{
	public static ETCInput _instance;

	private Dictionary<string, ETCAxis> axes;

	private Dictionary<string, ETCBase> controls;

	private static ETCBase control;

	private static ETCAxis axis;

	public static ETCInput instance => null;

	public void RegisterControl(ETCBase ctrl)
	{
	}

	public void UnRegisterControl(ETCBase ctrl)
	{
	}

	public void Create()
	{
	}

	public static void Register(ETCBase ctrl)
	{
	}

	public static void UnRegister(ETCBase ctrl)
	{
	}

	public static void SetControlVisible(string ctrlName, bool value)
	{
	}

	public static bool GetControlVisible(string ctrlName)
	{
		return false;
	}

	public static void SetControlActivated(string ctrlName, bool value)
	{
	}

	public static bool GetControlActivated(string ctrlName)
	{
		return false;
	}

	public static void SetControlSwipeIn(string ctrlName, bool value)
	{
	}

	public static bool GetControlSwipeIn(string ctrlName)
	{
		return false;
	}

	public static void SetControlSwipeOut(string ctrlName, bool value)
	{
	}

	public static bool GetControlSwipeOut(string ctrlName, bool value)
	{
		return false;
	}

	public static void SetDPadAxesCount(string ctrlName, ETCBase.DPadAxis value)
	{
	}

	public static ETCBase.DPadAxis GetDPadAxesCount(string ctrlName)
	{
		return default(ETCBase.DPadAxis);
	}

	public static ETCJoystick GetControlJoystick(string ctrlName)
	{
		return null;
	}

	public static ETCDPad GetControlDPad(string ctrlName)
	{
		return null;
	}

	public static ETCTouchPad GetControlTouchPad(string ctrlName)
	{
		return null;
	}

	public static ETCButton GetControlButton(string ctrlName)
	{
		return null;
	}

	public static void SetControlSprite(string ctrlName, Sprite spr, Color color = default(Color))
	{
	}

	public static void SetJoystickThumbSprite(string ctrlName, Sprite spr, Color color = default(Color))
	{
	}

	public static void SetButtonSprite(string ctrlName, Sprite sprNormal, Sprite sprPress, Color color = default(Color))
	{
	}

	public static void SetAxisSpeed(string axisName, float speed)
	{
	}

	public static void SetAxisGravity(string axisName, float gravity)
	{
	}

	public static void SetTurnMoveSpeed(string ctrlName, float speed)
	{
	}

	public static void ResetAxis(string axisName)
	{
	}

	public static void SetAxisEnabled(string axisName, bool value)
	{
	}

	public static bool GetAxisEnabled(string axisName)
	{
		return false;
	}

	public static void SetAxisInverted(string axisName, bool value)
	{
	}

	public static bool GetAxisInverted(string axisName)
	{
		return false;
	}

	public static void SetAxisDeadValue(string axisName, float value)
	{
	}

	public static float GetAxisDeadValue(string axisName)
	{
		return 0f;
	}

	public static void SetAxisSensitivity(string axisName, float value)
	{
	}

	public static float GetAxisSensitivity(string axisName)
	{
		return 0f;
	}

	public static void SetAxisThreshold(string axisName, float value)
	{
	}

	public static float GetAxisThreshold(string axisName)
	{
		return 0f;
	}

	public static void SetAxisInertia(string axisName, bool value)
	{
	}

	public static bool GetAxisInertia(string axisName)
	{
		return false;
	}

	public static void SetAxisInertiaSpeed(string axisName, float value)
	{
	}

	public static float GetAxisInertiaSpeed(string axisName)
	{
		return 0f;
	}

	public static void SetAxisInertiaThreshold(string axisName, float value)
	{
	}

	public static float GetAxisInertiaThreshold(string axisName)
	{
		return 0f;
	}

	public static void SetAxisAutoStabilization(string axisName, bool value)
	{
	}

	public static bool GetAxisAutoStabilization(string axisName)
	{
		return false;
	}

	public static void SetAxisAutoStabilizationSpeed(string axisName, float value)
	{
	}

	public static float GetAxisAutoStabilizationSpeed(string axisName)
	{
		return 0f;
	}

	public static void SetAxisAutoStabilizationThreshold(string axisName, float value)
	{
	}

	public static float GetAxisAutoStabilizationThreshold(string axisName)
	{
		return 0f;
	}

	public static void SetAxisClampRotation(string axisName, bool value)
	{
	}

	public static bool GetAxisClampRotation(string axisName)
	{
		return false;
	}

	public static void SetAxisClampRotationValue(string axisName, float min, float max)
	{
	}

	public static void SetAxisClampRotationMinValue(string axisName, float value)
	{
	}

	public static void SetAxisClampRotationMaxValue(string axisName, float value)
	{
	}

	public static float GetAxisClampRotationMinValue(string axisName)
	{
		return 0f;
	}

	public static float GetAxisClampRotationMaxValue(string axisName)
	{
		return 0f;
	}

	public static void SetAxisDirecTransform(string axisName, Transform value)
	{
	}

	public static Transform GetAxisDirectTransform(string axisName)
	{
		return null;
	}

	public static void SetAxisDirectAction(string axisName, ETCAxis.DirectAction value)
	{
	}

	public static ETCAxis.DirectAction GetAxisDirectAction(string axisName)
	{
		return default(ETCAxis.DirectAction);
	}

	public static void SetAxisAffectedAxis(string axisName, ETCAxis.AxisInfluenced value)
	{
	}

	public static ETCAxis.AxisInfluenced GetAxisAffectedAxis(string axisName)
	{
		return default(ETCAxis.AxisInfluenced);
	}

	public static void SetAxisOverTime(string axisName, bool value)
	{
	}

	public static bool GetAxisOverTime(string axisName)
	{
		return false;
	}

	public static void SetAxisOverTimeStep(string axisName, float value)
	{
	}

	public static float GetAxisOverTimeStep(string axisName)
	{
		return 0f;
	}

	public static void SetAxisOverTimeMaxValue(string axisName, float value)
	{
	}

	public static float GetAxisOverTimeMaxValue(string axisName)
	{
		return 0f;
	}

	public static float GetAxis(string axisName)
	{
		return 0f;
	}

	public static float GetAxisSpeed(string axisName)
	{
		return 0f;
	}

	public static bool GetAxisDownUp(string axisName)
	{
		return false;
	}

	public static bool GetAxisDownDown(string axisName)
	{
		return false;
	}

	public static bool GetAxisDownRight(string axisName)
	{
		return false;
	}

	public static bool GetAxisDownLeft(string axisName)
	{
		return false;
	}

	public static bool GetAxisPressedUp(string axisName)
	{
		return false;
	}

	public static bool GetAxisPressedDown(string axisName)
	{
		return false;
	}

	public static bool GetAxisPressedRight(string axisName)
	{
		return false;
	}

	public static bool GetAxisPressedLeft(string axisName)
	{
		return false;
	}

	public static bool GetButtonDown(string buttonName)
	{
		return false;
	}

	public static bool GetButton(string buttonName)
	{
		return false;
	}

	public static bool GetButtonUp(string buttonName)
	{
		return false;
	}

	public static float GetButtonValue(string buttonName)
	{
		return 0f;
	}

	private void RegisterAxis(ETCAxis axis)
	{
	}

	private void UnRegisterAxis(ETCAxis axis)
	{
	}
}
