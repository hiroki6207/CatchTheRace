using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;
using DG.Tweening;

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
            DOVirtual.DelayedCall(3.0f, Retry, false);
            // T.B.D 衝突時のエフェクトを生成
        }
    }

    public void Retry()
    {
        gameOverCanvas.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
