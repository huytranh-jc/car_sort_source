using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	[AddComponentMenu("Lean/Localization/Lean Localized Text")]
	[RequireComponent(typeof(Text))]
	[DisallowMultipleComponent]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedText")]
	[ExecuteInEditMode]
	public class LeanLocalizedText : LeanLocalizedBehaviour
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
