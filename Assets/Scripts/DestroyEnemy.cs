using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField]
    ParticleSystem ps;

    
    // Start is called before the first frame update
    void Start()
    {
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide wiyh >>> " + collision.gameObject.name);
        ps.Play();
        Invoke("DestroyThisEnemy", 0.2f);
    }

    void DestroyThisEnemy()
    {
        ps.Stop();
        Destroy(this.gameObject);

    }
}
