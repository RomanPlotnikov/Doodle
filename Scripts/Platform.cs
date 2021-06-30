using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Doodle.doodleRigid.velocity = Vector2.up * forceJump;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadZone")
        {
            float rndX = Random.Range(-1.7f, 1.7f);
            float rndY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector2(rndX, rndY);
        }
    }
  
}
