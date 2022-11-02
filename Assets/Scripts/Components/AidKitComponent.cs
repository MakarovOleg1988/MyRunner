using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
	public class AidKitComponent : MonoBehaviour
	{
		public static AidKitComponent instance;
		public static AidKitScript _aidKitScript;
		[SerializeField] public AudioSource _aidKitSound;
		[SerializeField] protected float _speedRotate;

		private void Start()
		{
			instance = this;
		}
	}
}
