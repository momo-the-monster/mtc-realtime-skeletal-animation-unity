using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePose : MonoBehaviour {

    public Animator animator;
    private string poseKey = "Pose";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            animator.SetInteger(poseKey, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetInteger(poseKey, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetInteger(poseKey, 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetInteger(poseKey, 3);
        }
    }
}
