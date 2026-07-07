using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Localization
{
	[ExecuteInEditMode]
	[HelpURL("http://carloswilkes.github.io/Documentation/LeanLocalization#LeanToken")]
	[AddComponentMenu("Lean/Localization/Lean Token")]
	public class LeanToken : LeanSource
	{
		[SerializeField]
		private string value;

		[NonSerialized]
		private HashSet<ILocalizationHandler> handlers;

		[NonSerialized]
		private static HashSet<ILocalizationHandler> tempHandlers;

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetValue(float value)
		{
		}

		public void SetValue(string value)
		{
		}

		public void SetValue(int value)
		{
		}

		public void Register(ILocalizationHandler handler)
		{
		}

		public void Unregister(ILocalizationHandler handler)
		{
		}

		public void UnregisterAll()
		{
		}

		public override void Compile(string primaryLanguage, string secondaryLanguage)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
