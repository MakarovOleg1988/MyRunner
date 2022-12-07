using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
	public class CoinsComponents : MonoBehaviour
	{	
		[SerializeField] protected float _speedRotate;
		protected int _coin = 0;

		public float GetRotate => _speedRotate;
	}
}
