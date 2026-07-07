using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Text))]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedTextFont")]
	[AddComponentMenu("Lean/Localization/Lean Localized TextFont")]
	public class LeanLocalizedTextFont : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this font will be used")]
		public Font FallbackFont;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
