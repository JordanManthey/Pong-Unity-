using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 translate = new Vector3(0, 0, 0.025f);

        if (GameObject.FindGameObjectWithTag("Puck").transform.position[2] > this.transform.position[2])
        {
            if (this.transform.position[2] + 0.5f <= 4.8f)
            {
                this.transform.position = this.transform.position + translate;
            }
        } else if (GameObject.FindGameObjectWithTag("Puck").transform.position[2] < this.transform.position[2])
        {
            if (this.transform.position[2] - 0.5f >= -4.8f)
            {
                this.transform.position = this.transform.position - translate;
            }
        }
		
	}
}
