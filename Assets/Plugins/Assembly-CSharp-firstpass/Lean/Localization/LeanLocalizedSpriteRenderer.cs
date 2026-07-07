using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SpriteRenderer))]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedSpriteRenderer")]
	[AddComponentMenu("Lean/Localization/Lean Localized SpriteRenderer")]
	public class LeanLocalizedSpriteRenderer : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this sprite will be used")]
		public Sprite FallbackSprite;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
