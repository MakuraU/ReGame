using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoArrangeCubes : MonoBehaviour
{
    public GameObject cubePrefab; // CubeԤ�Ƽ�
    public Vector3 startPosition; // ��ʼλ��
    public float interval = 2f; // ���

    void Start()
    {
        ArrangeCubes();
    }

    void ArrangeCubes()
    {
        Vector3 position = startPosition;
        int cubeCount = transform.childCount; // ����������

        for (int i = 0; i < cubeCount; i++)
        {
            // ����Cube������λ��
            GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity, transform);
            position.z += interval; // ����λ��
        }
    }
}
