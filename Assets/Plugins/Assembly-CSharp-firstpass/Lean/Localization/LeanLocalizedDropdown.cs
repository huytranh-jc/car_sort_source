using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	[AddComponentMenu("Lean/Localization/Lean Localized Dropdown")]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalizedDropdown")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Dropdown))]
	public class LeanLocalizedDropdown : MonoBehaviour, ILocalizationHandler
	{
		[Serializable]
		public class Option
		{
			[LeanTranslationName]
			public string StringTranslationName;

			[LeanTranslationName]
			public string SpriteTranslationName;

			[Tooltip("If StringTranslationName couldn't be found, this text will be used")]
			public string FallbackText;

			[Tooltip("If SpriteTranslationName couldn't be found, this sprite will be used")]
			public Sprite FallbackSprite;
		}

		[SerializeField]
		private List<Option> options;

		[NonSerialized]
		private HashSet<LeanToken> tokens;

		public List<Option> Options => null;

		public void Register(LeanToken token)
		{
		}

		public void Unregister(LeanToken token)
		{
		}

		public void UnregisterAll()
		{
		}

		[ContextMenu("Update Localization")]
		public void UpdateLocalization()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
