using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
	public abstract class CarsComponents : MonoBehaviour
	{
		protected Transform _moveVectorCar;
		[SerializeField] protected float speed;
		[SerializeField] protected float TimeBwtMove;
		[SerializeField] protected float timeToWaiting;
		protected bool _carNotDestroy = true;
		[SerializeField] protected bool _carMoveRight = true;
	}
}
 