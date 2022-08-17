using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWallController : MonoBehaviour
{

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
        Destroy(other.gameObject);
        ScoreController.ClearScore();
    }
}
