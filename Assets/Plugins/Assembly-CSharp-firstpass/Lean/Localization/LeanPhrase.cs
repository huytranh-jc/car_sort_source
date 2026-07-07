using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Localization
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanPhrase")]
	[AddComponentMenu("Lean/Localization/Lean Phrase")]
	public class LeanPhrase : LeanSource
	{
		public enum DataType
		{
			Text = 0,
			Object = 1,
			Sprite = 2
		}

		[Serializable]
		public class Entry
		{
			public string Language;

			public string Text;

			public UnityEngine.Object Object;
		}

		[SerializeField]
		private DataType data;

		[FormerlySerializedAs("translations")]
		[SerializeField]
		private List<Entry> entries;

		public DataType Data
		{
			get
			{
				return default(DataType);
			}
			set
			{
			}
		}

		public List<Entry> Entries => null;

		public void Clear()
		{
		}

		public override void Compile(string primaryLanguage, string secondaryLanguage)
		{
		}

		private void Compile(LeanTranslation translation, Entry entry, bool primary)
		{
		}

		private void Compile(LeanTranslation translation, object data, bool primary)
		{
		}

		public bool TryFindTranslation(string languageName, ref Entry entry)
		{
			return false;
		}

		public void RemoveTranslation(string languageName)
		{
		}

		public Entry AddEntry(string languageName, string text = null, UnityEngine.Object obj = null)
		{
			return null;
		}
	}
}
