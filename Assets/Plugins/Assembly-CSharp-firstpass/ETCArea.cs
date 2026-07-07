using System;
using UnityEngine;

[Serializable]
public class ETCArea : MonoBehaviour
{
	public enum AreaPreset
	{
		Choose = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomLeft = 3,
		BottomRight = 4
	}

	public bool show;

	public void Awake()
	{
	}

	public void ApplyPreset(AreaPreset preset)
	{
	}
}
