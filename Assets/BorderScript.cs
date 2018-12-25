using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {

    private ScoreUI score;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        score = FindObjectOfType<ScoreUI>();
        rb = FindObjectOfType<PuckScript>().GetComponent<Rigidbody>();
        rb = FindObjectOfType<PuckScript>().GetComponent<Rigidbody>();
	}

    void OnCollisionEnter(Collision c)
    {
        Vector3 force = new Vector3(400, 0, 50);
        Vector3 stop = new Vector3(0, 0, 0);
        score.scorePlayer = score.scorePlayer + 1;
        GameObject.FindGameObjectWithTag("Puck").transform.position = new Vector3(0, 1, 0);
        GameObject.FindGameObjectWithTag("AI").transform.position = new Vector3(-8, 1, 0);
        rb.velocity = new Vector3(0, 0, 0);
        if (score.scorePlayer == 5 || score.scorePlayerAI == 5)
        {
            rb.AddForce(stop);
        } else
        {
            rb.AddForce(force);
        }
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
