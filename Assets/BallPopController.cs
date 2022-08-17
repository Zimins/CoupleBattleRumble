using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPopController : MonoBehaviour
{
    public float expolsionForce = 600f;
    public ScoreController ScoreController; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log("Collision on capsule");
        ScoreController.AddPoint();
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        transform.localScale = new Vector3(1f, 1f, 1f);
        if (other.gameObject.tag == "Ball") {
            other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(expolsionForce, transform.position, 1f);
        } 
    }
}
