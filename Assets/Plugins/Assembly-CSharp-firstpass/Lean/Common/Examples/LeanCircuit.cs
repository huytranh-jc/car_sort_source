using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Common.Examples
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(MeshFilter))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LeanCircuit : MonoBehaviour
	{
		[Serializable]
		public class Path
		{
			public List<Vector3> Points;
		}

		private class Node
		{
			public Vector3 Point;

			public int Count;

			public bool Increment(Vector3 p)
			{
				return false;
			}
		}

		public List<Path> Paths;

		public float LineRadius;

		public float PointRadius;

		public Color ShadowColor;

		public Vector3 ShadowOffset;

		[NonSerialized]
		private MeshFilter cachedMeshFilter;

		[NonSerialized]
		private bool cachedMeshFilterSet;

		[NonSerialized]
		private Mesh mesh;

		private static List<Vector3> positions;

		private static List<Vector3> normals;

		private static List<Color> colors;

		private static List<Vector2> coords;

		private static List<int> indices;

		private static List<Node> nodes;

		[ContextMenu("Update Mesh")]
		public void UpdateMesh()
		{
		}

		private void Populate()
		{
		}

		protected virtual void Start()
		{
		}

		private void AddLine(Vector3 a, Vector3 b, Color color)
		{
		}

		private void AddPoint(Vector3 a, float radius, Color color)
		{
		}

		private void AddNode(Vector3 point)
		{
		}
	}
}
