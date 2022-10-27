using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    float timer = 0;
    public GameObject enemy;
    public float delayEnemy = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > delayEnemy)
        {
            Instantiate(enemy, new Vector3(Random.Range(2f, 4f), Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
            timer = 0;
        }
    }
}
