using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField]
    private double moveSped;
    private Vector3 target;
	// Use this for initialization
	void Start () {
        target = GameObject.FindObjectOfType<PlayerController>().transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(target);

        if (this.transform.position != target)
        {
            target = GameObject.FindObjectOfType<PlayerController>().transform.position;
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, (float)moveSped * Time.deltaTime);
            //Debug.Log("aaa");
        }
	}
}
