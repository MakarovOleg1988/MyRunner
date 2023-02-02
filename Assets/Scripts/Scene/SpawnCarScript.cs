using UnityEngine;

namespace MyRunner
{
    public class SpawnCarScript : MonoBehaviour
    {
        CarsComponents carsComponents;

        [SerializeField] private GameObject[] _cars;
        [SerializeField] private GameObject[] _cars2;
        [SerializeField] private GameObject[] _cars3;
        [SerializeField] private carChoose _carChoose;
        public Transform _spawnpoint;
        private float _timebetweenspawn;
        private bool _carcreate;

        private void Update()
        {
            SpawnCar();
        }

        public void SpawnCar()
        {
            switch (_carChoose)
            {
                case carChoose.MoveRigth:
                    {
                        if (_timebetweenspawn <= 0)
                        {
                            var randomID = Random.Range(0, 1);
                            var Car = Instantiate(_cars[randomID], _spawnpoint.position, Quaternion.identity);
                            Car.transform.eulerAngles = new Vector3(0f, 90f, 0f);
                            _timebetweenspawn = 3f;
                        }
                        else _timebetweenspawn -= Time.deltaTime;
                    }; break;
                case carChoose.MoveLeft:
                    {
                        if (_timebetweenspawn <= 0)
                        {
                            var randomID = Random.Range(0, 1);
                            var Car = Instantiate(_cars2[randomID], _spawnpoint.position, Quaternion.identity);
                            Car.transform.eulerAngles = new Vector3(0f, -90f, 0f);
                            _timebetweenspawn = 3f;
                        }
                        else _timebetweenspawn -= Time.deltaTime;
                    }; break;
                case carChoose.Standing:
                    {
                        if (_carcreate == false)
                        {
                            var randomID = Random.Range(0, 5);
                            var Car = Instantiate(_cars3[randomID], _spawnpoint.position, Quaternion.identity);
                            Car.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                            _carcreate = true;
                        }
                    }; break;
                default: break;
            }
        }  
    }
}
