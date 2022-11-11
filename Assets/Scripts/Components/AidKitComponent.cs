using UnityEngine;

namespace MyRunner
{
	public abstract class AidKitComponent : MonoBehaviour
	{
		public static AidKitComponent instance;
		[SerializeField] public float _speedRotate;
		[SerializeField] public AudioSource _aidKitSound;

		private void Start()
		{
			instance = this;
		}
	}
}