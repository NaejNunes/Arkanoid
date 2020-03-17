using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHorizontalPhysicsMovimentBehaviour : MonoBehaviour
{
    public float speed = 1.5f;
    public float paddleLimit = 6.90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
            currentPosition.x += speed;
        else if (Input.GetKey(KeyCode.LeftArrow))
            currentPosition.x -= speed;

        if (currentPosition.x >= -paddleLimit && currentPosition.x <= paddleLimit)
            GetComponent<Rigidbody2D>().MovePosition(currentPosition);
    }
}
