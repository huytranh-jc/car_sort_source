using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Renderer))]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedRenderer")]
	[AddComponentMenu("Lean/Localization/Lean Localized Renderer")]
	public class LeanLocalizedRenderer : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this material will be used")]
		public Material FallbackMaterial;

		[Tooltip("The material index you want to replace.")]
		public int Index;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
