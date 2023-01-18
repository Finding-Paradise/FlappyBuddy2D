using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float deadZone = -40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
