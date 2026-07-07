using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanLanguageCSV")]
	[AddComponentMenu("Lean/Localization/Lean Language CSV")]
	public class LeanLanguageCSV : LeanSource
	{
		[Serializable]
		public class Entry
		{
			public string Name;

			public string Text;
		}

		public enum CacheType
		{
			LoadImmediately = 0,
			LazyLoad = 1,
			LazyLoadAndUnload = 2,
			LazyLoadAndUnloadPrimaryOnly = 3
		}

		public TextAsset Source;

		[LeanLanguageName]
		public string Language;

		public string Separator;

		public string NewLine;

		public string Comment;

		public CacheType Cache;

		[SerializeField]
		private List<Entry> entries;

		private static readonly char[] newlineCharacters;

		private static Stack<Entry> entryPool;

		public List<Entry> Entries => null;

		public override void Compile(string primaryLanguage, string defaultLanguage)
		{
		}

		[ContextMenu("Clear")]
		public void Clear()
		{
		}

		[ContextMenu("Load From Source")]
		public void LoadFromSource()
		{
		}
	}
}
