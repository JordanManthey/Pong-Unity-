using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool up = Input.GetKey("up");
        bool down = Input.GetKey("down");
        Vector3 translate = new Vector3(0, 0, 0.2f);

        if (up)
        {
            if (this.transform.position[2] + 0.5f <= 4.8f)
            {
                this.transform.position = this.transform.position + translate;
            }
        } else if (down)
        {
            if (this.transform.position[2] - 0.5f >= -4.8f)
            {
                this.transform.position = this.transform.position - translate;
            }

        }
	}
}
