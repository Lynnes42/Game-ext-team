using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushuroom : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField]float speed;
    [SerializeField]Transform player;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        Andar();
        follow();
    }

    void Andar()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void follow()
    {
        if(player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1,1,0);
        }
        else
        {
            transform.localScale = new Vector3(-1,1,0);
        }
    }
    
}
