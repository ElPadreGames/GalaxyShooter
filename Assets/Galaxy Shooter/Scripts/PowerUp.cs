using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    [SerializeField]
    private float _speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.down * Time.deltaTime * _speed);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with: " + other.name);
        if (other.isTrigger)  
        {
            if (other.tag == "Player")
            {
                Player player = other.GetComponent<Player>();

                if (player != null)
                {
                    player.TripleShotPowerUpOn();
                }
                Destroy(this.gameObject);
            }
        }
    }


}
