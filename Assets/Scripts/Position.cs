﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    float moveX, moveY;

    [Header("이동속도 조절")]
    [SerializeField] [Range(1f, 30f)] float moveSpeed = 20f;

    void Update()
    {
        //이동 (WASD 혹은 상하좌우 이동키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }
}
