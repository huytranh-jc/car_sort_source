using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Localization
{
	public abstract class LeanLocalizedBehaviour : MonoBehaviour, ILocalizationHandler
	{
		[FormerlySerializedAs("translationTitle")]
		[FormerlySerializedAs("phraseName")]
		[LeanTranslationName]
		[Tooltip("The name of the phrase we want to use for this localized component")]
		[SerializeField]
		private string translationName;

		[NonSerialized]
		private HashSet<LeanToken> tokens;

		public string TranslationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Register(LeanToken token)
		{
		}

		public void Unregister(LeanToken token)
		{
		}

		public void UnregisterAll()
		{
		}

		public abstract void UpdateTranslation(LeanTranslation translation);

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
