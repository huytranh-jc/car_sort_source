using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(TextMesh))]
	[AddComponentMenu("Lean/Localization/Lean Localized TextMesh")]
	public class LeanLocalizedTextMesh : LeanLocalizedBehaviour
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
