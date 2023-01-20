using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBallsSpawn : MonoBehaviour
{
    //[SerializeField] private IronBall[] ironBalls;
    // コードレビュー_1：生成するのはプレハブ（ゲームオブジェクト）になります
    [SerializeField] private GameObject ironBallPrefab;
    [SerializeField] private Transform prefab;
    [SerializeField] private Vector3 pos;

    private void Start()
    {
        prefab = this.transform;
        pos = prefab.position;
        StartCoroutine(IronBallCreate());
    }

    private void Update()
    {

        StartCoroutine(IronBallCreate());
    }

    public IEnumerator IronBallCreate()
    {
        yield return new WaitForSeconds(5.0f);
        Instantiate(ironBallPrefab, pos, Quaternion.identity);
    }
}
