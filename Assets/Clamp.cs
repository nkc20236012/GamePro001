using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    // x�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minX = -10.5f;
    [SerializeField] private float _maxX = 10.5f;
    [SerializeField] private float _minY = -4;
    [SerializeField] private float _maxY = 4;

    private void Update()
    {
        Vector3 pos = transform.position;

        // x�������̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;
    }
}