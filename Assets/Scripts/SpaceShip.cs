using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{
    [SerializeField]
    float speed = 0.2f;

    [SerializeField] GameObject missile;

   // [SerializeField] GameObject enemyObjectParent;

    [SerializeField] Transform  asteroidPos, enemyPos;


    Vector3 startPosShip, startPosAsteroids, startEnemyPos;
    // Start is called before the first frame update
    void Start()
    {
        startPosShip = this.transform.position;
        startPosAsteroids = asteroidPos.position;
        startEnemyPos = enemyPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    public void RotateShip()
    {
        //Vector3 currentPos = transform.position;
        transform.Rotate(new Vector3(0f, 180f, 0f));
        //transform.position = currentPos;
       
    }


    public void TriggerMissile()
    {
        GameObject missss =  GameObject.Instantiate(missile);
        //missile = GameObject.Instantiate(missile, parentOfMissile);

        missss.transform.position = transform.position;
    }


    public void Reset()
    {
        this.transform.position = startPosShip;
        asteroidPos.position = startPosAsteroids;
        enemyPos.position = startEnemyPos;

        //if (FindObjectOfType<DestroyEnemy>() == null)
        //{
        //    Debug.Log("All Enemies are died..");
        //    //Destroy(FindObjectOfType<EnemyShip>().gameObject);
        //    enemyObjectParent = GameObject.Instantiate(enemyObjectParent, enemyPos);
        //    enemyObjectParent.transform.position = startEnemyPos;
        //}
        //else
        //    enemyPos.position = startEnemyPos;

        Missile[] missiless = FindObjectsOfType<Missile>();
        if (missiless != null)
        {
            foreach (var v in missiless)
            {
                Destroy(v.gameObject);
            }
        }

    }


    public void ReloadScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
