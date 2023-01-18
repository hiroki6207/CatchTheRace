using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

[RequireComponent(typeof(Button))]
public class ReplayButton : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var button = GetComponent<Button>();
        //�{�^���������������̃��X�i�[��ݒ�
        button.onClick.AddListener(async () =>
        {
            GameObject.Find("FadeInOutPanel").GetComponent<FadeInOut>().Fadeout();
            await Task.Delay(3000);
            //�V�[���J�ڂ̍ۂɂ�SceneManager���g�p����
            SceneManager.LoadScene("TitleScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
