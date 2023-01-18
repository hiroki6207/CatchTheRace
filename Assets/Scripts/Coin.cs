using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float thrust = 1.0f;
    [SerializeField] public Rigidbody rb;
    [SerializeField] public Transform prefab;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && rb != null)
        {
            Vector3 hitPos = new Vector3(0, 0, 0);
            foreach (ContactPoint point in collision.contacts)
            {
                hitPos = point.point;
            }
            Instantiate(prefab, hitPos, Quaternion.identity);
        }
    }

}
