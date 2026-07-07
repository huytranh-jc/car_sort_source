using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Localization
{
	[Serializable]
	public class LeanPrefab
	{
		public UnityEngine.Object Root;

		[SerializeField]
		private List<LeanSource> sources;

		[NonSerialized]
		private int buildingCount;

		[NonSerialized]
		private bool buildingModified;

		private static List<LeanSource> tempSources;

		public List<LeanSource> Sources => null;

		public bool RebuildSources()
		{
			return false;
		}

		private bool FinalizeBuild()
		{
			return false;
		}

		private void AddSource(LeanSource source)
		{
		}

		private void FindFromGameObject(Transform prefab)
		{
		}
	}
}
