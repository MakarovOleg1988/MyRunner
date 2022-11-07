using UnityEngine;

namespace MyRunner
{
	public class AidKitComponent : MonoBehaviour
	{
		public static AidKitComponent instance;
		public static HealthManager _HealthManager;
		[SerializeField] public AudioSource _aidKitSound;
		[SerializeField] protected float _speedRotate;

		private void Start()
		{
			instance = this;
		}
	}
}
