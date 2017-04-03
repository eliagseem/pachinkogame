using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperSpawnScript : MonoBehaviour {

    public Transform PachinkoBallPrefab;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate ball prefab slightly lower than where the dropper is, then add force to push it down and make it ~bounce~
            var ballClone = Instantiate(PachinkoBallPrefab, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), transform.rotation);
            ballClone.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100));
        }

	}
}
