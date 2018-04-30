using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move up at 10 speed
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        //is position on the y is bigger than ...destroy the laser
        if (transform.position.y >+ 6)
        {
            Destroy(this.gameObject);
        }

	}
}
