using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject barrier;
    public ScoreManager scoreManager;
    float cooldown_;

    // Start is called before the first frame update
    void Start()
    {
        cooldown_ = (3f - (scoreManager.score / 10));
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    void Cooldown()
    {
        if (cooldown_ > 0)
        {
            cooldown_ -= Time.deltaTime;
        }
        else
        {
            SpawnColumns();
            cooldown_ = 3f; 
        } 
    }

    void SpawnColumns()
    {
        Instantiate(barrier, new Vector3(5, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}