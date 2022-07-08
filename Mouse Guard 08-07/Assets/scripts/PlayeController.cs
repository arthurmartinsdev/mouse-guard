using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D playerRb;

    public class Example : MonoBehaviour
    {
        bool characterInQuicksand = false;

        void OnTriggerStay2D(Collider2D collider)
        {
            collider.attachedRigidbody.AddForce(-0.1f * collider.attachedRigidbody.velocity);
        }
    }

    Vector2 movimento;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movimento * speed * Time.fixedDeltaTime);
    }
}