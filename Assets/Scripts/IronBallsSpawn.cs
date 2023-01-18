using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBallsSpawn : MonoBehaviour
{
    [SerializeField] private IronBall[] ironBalls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(IronBallCreate());
    }

    public IEnumerator IronBallCreate()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
