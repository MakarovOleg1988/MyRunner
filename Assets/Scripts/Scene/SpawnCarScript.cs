using UnityEngine;

namespace MyRunner
{
    public class SpawnCarScript : MonoBehaviour
    {
        public GameObject _car;
        public Transform _spawnpoint;
        public float _timebetweenspawn;

        private void Update()
        {
            SpawnCar();
        }

        void SpawnCar()
        {
            if (_timebetweenspawn <= 0)
            {
                    Instantiate(_car, _spawnpoint.position, Quaternion.identity);
                _timebetweenspawn = 3f;
                }
            else _timebetweenspawn -= Time.deltaTime;
        }
    }
}
