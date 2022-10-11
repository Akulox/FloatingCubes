using UnityEngine;

namespace Script
{
    public class Cube : MonoBehaviour
    {
        public float speed;
        public float distance;
        
        private Rigidbody _rigidbody;
        private Vector3 startPosition;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            startPosition = transform.position;
            _rigidbody.velocity = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * Vector3.right * speed;
        }
        private void FixedUpdate()
        {
            if (Vector3.Distance(startPosition, transform.position) >= distance)
            {
                Destroy(gameObject);
            }
        }
    }
}
