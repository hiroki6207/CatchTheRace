using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

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
            Time.timeScale = 0;
            // T.B.D 衝突時のエフェクトを生成
            gameOverCanvas.SetActive(true);
            StartCoroutine(RetryCoroutine());
        }
    }

    public IEnumerator RetryCoroutine()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
