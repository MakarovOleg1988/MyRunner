using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
	public class CoinsComponents : MonoBehaviour
	{	
		[SerializeField] public Text _CoinScore;
		[SerializeField] public AudioSource _coinSound;
		[SerializeField] protected float _speedRotate;
		public int _coin;

		public float GetRotate => _speedRotate;
	}
}
