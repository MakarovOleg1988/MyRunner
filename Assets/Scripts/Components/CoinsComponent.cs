using UnityEngine;

namespace MyRunner
{
	public class CoinsComponents : MonoBehaviour
	{	
		[SerializeField] public AudioSource _coinSound;
		[SerializeField] protected float _speedRotate;
		protected int _coin = 0;

		public float GetRotate => _speedRotate;
	}
}
