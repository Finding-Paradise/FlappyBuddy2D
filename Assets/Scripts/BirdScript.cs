using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D BirdRigidBody2D;
    public float flapStrength;

    [SerializeField] private AudioSource flappingSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flappingSoundEffect.Play();
            BirdRigidBody2D.velocity = Vector2.up * flapStrength;
        }
    }
}
