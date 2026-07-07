using UnityEngine;

namespace Lean.Localization
{
	[RequireComponent(typeof(TextMesh))]
	[ExecuteInEditMode]
	[AddComponentMenu("Lean/Localization/Lean Localized TextMesh Font")]
	[DisallowMultipleComponent]
	public class LeanLocalizedTextMeshFont : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this font asset will be used")]
		public Font FallbackFont;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
