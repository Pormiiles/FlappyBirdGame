using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float columnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        ColumnMovement();
    }

    void ColumnMovement()
    {
        transform.position += new Vector3(-columnSpeed * Time.deltaTime, 0, 0);
    }
}
