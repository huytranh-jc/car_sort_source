using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Lean.Localization
{
	public class LeanTranslation
	{
		public struct Entry
		{
			public string Language;

			public Object Owner;
		}

		[SerializeField]
		private string name;

		public object Data;

		public bool Primary;

		private List<Entry> entries;

		private static bool buffering;

		private static StringBuilder current;

		private static StringBuilder buffer;

		private static List<LeanToken> tokens;

		public string Name => null;

		public List<Entry> Entries => null;

		public LeanTranslation(string newName)
		{
		}

		public void Register(string language, Object owner)
		{
		}

		public void Clear()
		{
		}

		public int LanguageCount(string language)
		{
			return 0;
		}

		public static string FormatText(string rawText, string currentText = null, ILocalizationHandler handler = null)
		{
			return null;
		}

		private static bool Match(string a, StringBuilder b)
		{
			return false;
		}
	}
}
