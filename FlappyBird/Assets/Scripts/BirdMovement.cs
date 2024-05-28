using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameObject game_over;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BirdMovementUpDown();
    }

    void BirdMovementUpDown()
    {
        float verticalY = Input.GetAxisRaw("Vertical"); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            this.enabled = false;
            game_over.SetActive(true);
        }
    }
}
