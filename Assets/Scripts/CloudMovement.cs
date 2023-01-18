using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    float cloudMoveSpeed;
    float deadZone = -40f;

    public float GetCloudMoveSpeed(float opacity)
    {
        float moveSpeed;

        switch (opacity)
        {
            case 0.2f:
                moveSpeed = 2f;
                break;
            case 0.5f:
                moveSpeed = 4f;
                break;
            case 0.8f:
                moveSpeed = 6f;
                break;
            default:
                moveSpeed = 8f;
                break;
        }
        return moveSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        cloudMoveSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudMoveSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
