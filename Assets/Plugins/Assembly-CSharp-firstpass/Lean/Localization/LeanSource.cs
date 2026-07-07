using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Localization
{
	public abstract class LeanSource : MonoBehaviour
	{
		public static LinkedList<LeanSource> Instances;

		[NonSerialized]
		private LinkedListNode<LeanSource> node;

		public abstract void Compile(string primaryLanguage, string secondaryLanguage);

		public void Register()
		{
		}

		public void Unregister()
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
