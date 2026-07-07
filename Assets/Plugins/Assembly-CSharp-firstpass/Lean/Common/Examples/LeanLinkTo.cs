using UnityEngine;
using UnityEngine.EventSystems;

namespace Lean.Common.Examples
{
	[AddComponentMenu("Lean/Common/Lean Link To")]
	[ExecuteInEditMode]
	public class LeanLinkTo : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public enum LinkType
		{
			Publisher = 0,
			PreviousScene = 1,
			NextScene = 2
		}

		[SerializeField]
		private LinkType link;

		public LinkType Link
		{
			get
			{
				return default(LinkType);
			}
			set
			{
			}
		}

		protected virtual void Update()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private static int GetCurrentLevel()
		{
			return 0;
		}

		private static int GetLevelCount()
		{
			return 0;
		}

		private static void LoadLevel(int index)
		{
		}
	}
}
