using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
	public class CoinsComponents : MonoBehaviour
	{	
		public static CoinsComponents instance;

		[SerializeField] public Text _CoinScore;
		[SerializeField] public AudioSource _coinSound;
		[SerializeField] protected float _speedRotate;
		public int _coin = 0;

		public float GetRotate => _speedRotate;

		private void Start()
		{
			instance = this;
		}
	}
}
