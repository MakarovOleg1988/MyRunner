using UnityEngine;

namespace MyRunner
{
	public abstract class AidKitComponent : MonoBehaviour
	{
		public static AidKitComponent instance;
		[SerializeField] public AudioSource _aidKitSound ;
		[SerializeField] public float _speedRotate = 40f;

		private void Start()
		{
			instance = this;
		}
	}
}
