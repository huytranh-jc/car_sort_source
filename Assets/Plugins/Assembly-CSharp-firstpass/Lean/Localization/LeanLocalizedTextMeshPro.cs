using TMPro;
using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(TextMeshPro))]
	[AddComponentMenu("Lean/Localization/Lean Localized TextMesh")]
	[DisallowMultipleComponent]
	public class LeanLocalizedTextMeshPro : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this text will be used")]
		public string FallbackText;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
