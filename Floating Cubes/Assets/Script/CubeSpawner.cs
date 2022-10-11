using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class CubeSpawner : MonoBehaviour
    {
        public InputField speedInput;
        public InputField distanceInput;
        public GameObject cubePrefab;
        public float spawnCD;
        private float nextSpawn;

        void FixedUpdate()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnCD;
                Cube cube = Instantiate(cubePrefab, transform.position, Quaternion.Euler(0,Random.Range(0, 360),0)).GetComponent<Cube>();

                if (!float.TryParse(speedInput.text, out var speed) || speed < 0.5f)
                {
                    speed = 1f;
                }
                if (!float.TryParse(distanceInput.text, out var distance) || distance < 0.5f)
                {
                    distance = 1f;
                }
                
                cube.speed = speed;
                cube.distance = distance;
            }
        }
    }
}
