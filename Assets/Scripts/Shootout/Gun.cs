using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public bool isFiring;
    public Bullet bullet;
    public float cdBetweenShots;
    private float cdCounter;
    public Transform firePoint;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            cdCounter -= Time.deltaTime;
            if(cdCounter <= 0)
            {
                cdCounter = cdBetweenShots;
                Instantiate(bullet, firePoint.position, firePoint.rotation);
            }
        }
        else
        {
            cdCounter = 0;
        }
	}
}
