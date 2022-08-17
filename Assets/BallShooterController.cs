using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallShooterController : MonoBehaviour
{

    public GameObject ballSpawn;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        // CreateNewBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewBall() {
        GameObject newBall = Instantiate(ball, ballSpawn.transform.position, ballSpawn.transform.rotation);
        newBall.GetComponent<Rigidbody>().AddForce(ballSpawn.transform.forward * 1000);
    }
}
