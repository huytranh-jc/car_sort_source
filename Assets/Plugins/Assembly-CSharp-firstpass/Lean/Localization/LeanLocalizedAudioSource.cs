using UnityEngine;

namespace Lean.Localization
{
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedAudioSource")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(AudioSource))]
	[AddComponentMenu("Lean/Localization/Lean Localized AudioSource")]
	public class LeanLocalizedAudioSource : LeanLocalizedBehaviour
	{
		[Tooltip("If PhraseName couldn't be found, this clip will be used")]
		public AudioClip FallbackAudioClip;

		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		protected virtual void Awake()
		{
		}
	}
}
