using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Countdown : MonoBehaviour
{
    [SerializeField] public float countdown = 5.0f;
    public Text timeText;
    private bool isPose = false;
    private bool timeOuted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    async void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isPose)
            {
                isPose = false;
            }
            else
            {
                isPose = true;
            }
        }

        if (isPose)
        {
            timeText.text = "É|Å[ÉYíÜ";
            return;
        }
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f1") + "ïb";
        if (countdown <= 0)
        {
            if (timeOuted == false)
            {
                timeOuted = true;
                GameObject.Find("FadeInOutPanel").GetComponent<FadeInOut>().Fadeout();
                await Task.Delay(3000);
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
