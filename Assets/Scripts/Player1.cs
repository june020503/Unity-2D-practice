using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float moveSpeed;
    float xInput, yInput;

    Vector2 targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 위치를 따라 플레이어 이동
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 10f;

        if(Input.GetMouseButtonDown(0))
        {
            targetPos = mousePos;
        }

        //transform.position = mousePos;
    }
    private void FixedUpdate()
    {
        //키보드로 플레이어 이동
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);

        ClickToMove();

    }

    //마우스 클릭으로 플레이어 이동
    void ClickToMove()
    {
        transform.position=Vector2.MoveTowards(transform.position, targetPos, moveSpeed);
    }
}
