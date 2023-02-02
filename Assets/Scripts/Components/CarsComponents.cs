using UnityEngine;

namespace MyRunner
{
    public class CarsComponents : MonoBehaviour
    {
        protected Transform _moveVectorCar;
        [SerializeField] protected float speed;
        [SerializeField] protected float TimeBwtMove;
        [SerializeField] protected float timeToWaiting;
        protected bool _carNotDestroy = true;

        [SerializeField] private bool _carMoveRight;
        public bool CarMoveRight
        {
            get
            { return _carMoveRight; }
            set
            { _carMoveRight = value; }
        }
    }
}
 