using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroids : MonoBehaviour
{
    [SerializeField]
    float speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
       // transform.Rotate(new Vector3(0f, speed, 0f));
    }

    public void RotateAsteroids()
    {
        //Vector3 currentPos = transform.position;
        transform.Rotate(new Vector3(0f, 0f, 180f));
        //transform.position = currentPos;

    }

}
