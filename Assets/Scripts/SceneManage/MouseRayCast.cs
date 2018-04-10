using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour {

    public Camera camera;
    public GameObject particle;
    Ray ray;
    public RaycastHit hit;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            //if (hit.transform.gameObject != null)
            //{

            //}
            //Debug.Log(hit.transform.tag);
        }

    }
}

/*
 Ray ray;
    RaycastHit hit;

    public GameObject selected = null;

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject != null)
            {
                selected = hit.transform.gameObject;
            }
            //Debug.Log(hit.transform.tag);
        }

    }
 
*/
