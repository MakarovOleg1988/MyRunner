using System.Collections;
using UnityEngine;

namespace MyRunner
{
	public class CarMovementScript : CarsComponents
	{

		private void Start()
		{
			_moveVectorCar = GetComponent<Transform>();
			if(CarMoveRight == true) StartCoroutine(CarMovementRight());
			if (CarMoveRight == false) StartCoroutine(CarMovementLeft());
		}

		private IEnumerator MoveFromTo(Vector3 startPosition, Vector3 endPosition, float time)
		{
			var currentTime = 0f;
			while (currentTime < time)
			{
				transform.position = Vector3.Lerp(startPosition, endPosition, 1 - (time - currentTime) / time);
				currentTime += Time.deltaTime;
				yield return null;
			}
			transform.position = endPosition;
		}

		private IEnumerator CarMovementRight()
		{
			while (_carNotDestroy == true)
			{
				yield return MoveFromTo(transform.position, transform.position + new Vector3(50f, 0f, 0f), TimeBwtMove);
				yield return new WaitForSeconds(timeToWaiting);

				Destroy(this.gameObject);
				_carNotDestroy = false;
				yield return null;
			}
		}

		private IEnumerator CarMovementLeft()
		{
			while (_carNotDestroy == true)
			{
				yield return MoveFromTo(transform.position, transform.position + new Vector3(-50f, 0f, 0f), TimeBwtMove);
				yield return new WaitForSeconds(timeToWaiting);

				Destroy(this.gameObject);
				_carNotDestroy = false;
				yield return null;
			}
		}
	}
}
