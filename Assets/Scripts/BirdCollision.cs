using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public Transform player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "InvisibleTop")
        {
            FindObjectOfType<LogicScript>().EndGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y < -16)
        {
            FindObjectOfType<LogicScript>().EndGame();
        }
    }
}
