using UnityEngine;

namespace MyRunner
{
    public class SpawnCarScript : MonoBehaviour
    {
        [SerializeField] public GameObject _car;
        [SerializeField] public GameObject _carLeft;
        [SerializeField] private carChoose _carChoose;
        public Transform _spawnpoint;
        public float _timebetweenspawn;

        private void Update()
        {
            SpawnCar(_car, _carLeft);
        }

        public void SpawnCar(GameObject _car, GameObject _carLeft)
        {
            switch (_carChoose)
            {
                case carChoose.Car:
                    {
                        if (_timebetweenspawn <= 0)
                        {
                            Instantiate(_car, _spawnpoint.position, Quaternion.identity);
                            _timebetweenspawn = 3f;
                        }
                        else _timebetweenspawn -= Time.deltaTime;
                    }; break;
                case carChoose.LeftCar:
                    {
                        if (_timebetweenspawn <= 0)
                        {
                            Instantiate(_carLeft, _spawnpoint.position, Quaternion.identity);
                            _timebetweenspawn = 3f;
                        }
                        else _timebetweenspawn -= Time.deltaTime;
                    }; break;
            }
        }
    }
}
