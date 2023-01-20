using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBall : MonoBehaviour
{
    [SerializeField] private float thrust = 1.0f;
    [SerializeField] private Vector3 force;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform prefab;
    [SerializeField] private GameObject gameOverCanvas;
    void Start()
    {
        prefab = this.transform;
        Vector3 pos = prefab.position;
        force = new Vector3(1, 0, 0);
    }

    void Update()
    {
        //rb = GetComponent<Rigidbody>();
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
            // T.B.D 衝突時のエフェクトを生成
            //Instantiate(prefab, hitPos, Quaternion.identity);
            gameOverCanvas.SetActive(true);
        }
    }
}
