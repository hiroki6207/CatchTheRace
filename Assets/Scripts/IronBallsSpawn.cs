using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBallsSpawn : MonoBehaviour
{
    //[SerializeField] private IronBall[] ironBalls;
    // コードレビュー_1：生成するのはプレハブ（ゲームオブジェクト）になります
    [SerializeField] private GameObject ironBallPrefab;

    private void Start()
    {
        // コードレビュー_2：コルーチンの中で一定間隔処理を繰り返し実行させます
        StartCoroutine(IronBallCreate());
    }

    private void Update()
    {
        // コードレビュー_2：コルーチンの中で一定間隔処理を繰り返し実行させます
        //StartCoroutine(IronBallCreate());
    }

    public IEnumerator IronBallCreate()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
