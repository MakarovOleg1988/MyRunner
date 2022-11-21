using UnityEngine;

namespace MyRunner
{
	public abstract class AidKitComponent : MonoBehaviour
	{
		[SerializeField] public float _speedRotate;
		[SerializeField] public AudioSource _aidKitSound;
	}
}