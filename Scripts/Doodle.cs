using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doodle : MonoBehaviour
{
    [SerializeField] public static Rigidbody2D doodleRigid;
    private SpriteRenderer sprite;

    float horizontal;
    public static Doodle instance;
    void Awake()
    {        sprite = GetComponent<SpriteRenderer>();
        doodleRigid = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        sprite.flipX = Input.acceleration.x < 0 ? false : true;

        doodleRigid.velocity = new Vector2(Input.acceleration.x * 10f, doodleRigid.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(0);
        }
    }
}
