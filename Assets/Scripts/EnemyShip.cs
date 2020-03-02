using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{

    [SerializeField]
    float speed = 0.2f;

    [SerializeField]
    GameObject[] enemies;

    private void Start()
    {
        REsetEnemies();
    }
    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void REsetEnemies()
    {
     
        DestroyEnemy[] destroyEnemies = GetComponentsInChildren<DestroyEnemy>();
        if (destroyEnemies != null)
        {
            foreach (var v in destroyEnemies)
            {
                Destroy(v.gameObject);
            }
        }
        foreach (GameObject g in enemies)
        {
            //if(dist == 0)
            //{
            //    GameObject.Instantiate(g, transform);
            //    refTransform = g.transform;
            //}
            //else
            //{
            //    refTransform = transform;
            //    GameObject.Instantiate(g, new Vector3(transform.position.x + dist, transform.position.y, transform.position.z), Quaternion.identity); ;
            //    g.transform.SetParent(transform);
            //}

            GameObject.Instantiate(g, transform);
        }
    }
}
