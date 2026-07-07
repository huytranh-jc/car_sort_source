using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Image))]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedImage")]
	[AddComponentMenu("Lean/Localization/Lean Localized Image")]
	public class LeanLocalizedImage : LeanLocalizedBehaviour
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
