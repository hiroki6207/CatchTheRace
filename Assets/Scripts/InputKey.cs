using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    public GameObject image;
    public bool image_flog = true;
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Image");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("スペース");
            Debug.Log(image_flog);
            if (image_flog == true)
            {
                image.GetComponent<Image_hyouji>().Image_Hide();
                image_flog = false;
            }
            else
            {
                image.GetComponent<Image_hyouji>().Image_Active();
                image_flog = true;
            }
        }
    }
}
