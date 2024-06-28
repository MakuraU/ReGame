using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoArrangeCubes : MonoBehaviour
{
    public GameObject cubePrefab; // Cube预制件
    public Vector3 startPosition; // 起始位置
    public float interval = 2f; // 间隔

    void Start()
    {
        ArrangeCubes();
    }

    void ArrangeCubes()
    {
        Vector3 position = startPosition;
        int cubeCount = transform.childCount; // 子物体数量

        for (int i = 0; i < cubeCount; i++)
        {
            // 创建Cube并设置位置
            GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity, transform);
            position.z += interval; // 更新位置
        }
    }
}
