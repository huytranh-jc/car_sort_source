using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Lean.Localization
{
	[Serializable]
	public class LeanLanguage
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private List<string> cultures;

		[SerializeField]
		private Font font;

		[SerializeField]
		private TMP_FontAsset fontAsset;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> Cultures => null;

		public Font Font => null;

		public TMP_FontAsset FontAsset => null;
	}
}
