using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckScript : MonoBehaviour {

    private ScoreUI score;

    private Rigidbody rb;

    void Start()
    {
        score = FindObjectOfType<ScoreUI>();
        Vector3 force = new Vector3(400, 0, 50);
        rb = GetComponent<Rigidbody>();
        if ((score.scorePlayer == 5 || score.scorePlayerAI == 5))
        {
            rb.AddForce(new Vector3(0, 0, 0));
        } else
        {
            rb.AddForce(force);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
