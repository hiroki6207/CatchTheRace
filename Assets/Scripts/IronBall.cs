using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBall : MonoBehaviour
{
    [SerializeField] private float thrust = 1.0f;
    [SerializeField] Vector3 force;
    [SerializeField] public Rigidbody rb;
    [SerializeField] public Transform prefab;
    void Start()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        force = new Vector3(20, 0, 0);
    }

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(force, ForceMode.VelocityChange);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && rb != null)
        {
            Vector3 hitPos = new Vector3(0, 0, 0);
            foreach (ContactPoint point in collision.contacts)
            {
                hitPos = point.point;
            }
            //Instantiate(prefab, hitPos, Quaternion.identity);
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
        }
    }
}
