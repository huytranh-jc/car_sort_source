using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Lean.Localization
{
	[AddComponentMenu("Lean/Localization/Lean Localization")]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLocalization")]
	[ExecuteInEditMode]
	public class LeanLocalization : MonoBehaviour
	{
		public enum DetectType
		{
			None = 0,
			SystemLanguage = 1,
			CurrentCulture = 2,
			CurrentUICulture = 3
		}

		public const string HelpUrlPrefix = "http://carloswilkes.github.io/Documentation/LeanLocalization#";

		public const string ComponentPathPrefix = "Lean/Localization/Lean ";

		public static List<LeanLocalization> Instances;

		public static Dictionary<string, LeanToken> CurrentTokens;

		public static Dictionary<string, LeanLanguage> CurrentLanguages;

		public static Dictionary<string, LeanTranslation> CurrentTranslations;

		[LeanLanguageName]
		public string DefaultLanguage;

		public DetectType DetectLanguage;

		public bool SaveLanguage;

		[SerializeField]
		private List<LeanLanguage> languages;

		[SerializeField]
		private List<LeanPrefab> prefabs;

		private static string currentLanguage;

		private static bool pendingUpdates;

		private static Dictionary<string, LeanTranslation> tempTranslations;

		public List<LeanLanguage> Languages => null;

		public List<LeanPrefab> Prefabs => null;

		public static bool CurrentSaveLanguage => false;

		public static string CurrentLanguage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnLocalizationChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SetTextFont(Text text)
		{
		}

		public static void RegisterToken(string name, LeanToken token)
		{
		}

		public static LeanTranslation RegisterTranslation(string name)
		{
			return null;
		}

		[ContextMenu("Clear Save")]
		public void ClearSave()
		{
		}

		private static void SaveNow()
		{
		}

		private static void LoadNow()
		{
		}

		public void SetCurrentLanguage(string newLanguage)
		{
		}

		public void SetCurrentLanguage(int newLanguageIndex)
		{
		}

		public bool LanguageExists(string languageName)
		{
			return false;
		}

		public bool TryGetLanguage(string languageName, ref LeanLanguage language)
		{
			return false;
		}

		public void AddPrefab(UnityEngine.Object root)
		{
		}

		public LeanLanguage AddLanguage(string languageName, string[] cultures)
		{
			return null;
		}

		public static LeanToken AddTokenToFirst(string name)
		{
			return null;
		}

		public LeanToken AddToken(string name)
		{
			return null;
		}

		public static void SetToken(string name, string value, bool allowCreation = true)
		{
		}

		public static string GetToken(string name, string defaultValue = null)
		{
			return null;
		}

		public static LeanPhrase AddPhraseToFirst(string name)
		{
			return null;
		}

		public LeanPhrase AddPhrase(string name)
		{
			return null;
		}

		public static LeanTranslation GetTranslation(string name)
		{
			return null;
		}

		public static string GetTranslationText(string name, string fallback = null, bool replaceTokens = true)
		{
			return null;
		}

		public static T GetTranslationObject<T>(string name, T fallback = null) where T : UnityEngine.Object
		{
			return null;
		}

		public static void UpdateTranslations(bool forceUpdate = true)
		{
		}

		public static void DelayUpdateTranslations()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void RegisterAndBuild()
		{
		}

		private void UpdateCurrentLanguage()
		{
		}

		private string FindLanguageName(string alias)
		{
			return null;
		}
	}
}
