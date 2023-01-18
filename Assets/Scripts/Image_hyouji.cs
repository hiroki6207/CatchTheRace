using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image_hyouji : MonoBehaviour
{
    [SerializeField] private float x_position;
    [SerializeField] private float y_position;
    [SerializeField] private float z_position;
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
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.x = x_position;
        pos.y = y_position;
        pos.z = z_position;
    }

    public void Image_Active()
    {
        gameObject.SetActive(true);
    }

    public void Image_Hide()
    {
        gameObject.SetActive(false);
    }
}
