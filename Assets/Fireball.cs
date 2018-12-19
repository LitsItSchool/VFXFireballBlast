using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
    public float speed;
    public GameObject fireball;
    public GameObject blast;
    private bool isMoving;
	// Use this for initialization
	void Start () {
        isMoving = true;

    }
	
	// Update is called once per frame
	void Update () {
        if(isMoving)
        { 
            transform.Translate(Vector3.right*speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        fireball.SetActive(false);
        isMoving = false;
        blast.SetActive(true);
        StartCoroutine(SomeDelay());
        other.GetComponent<Rigidbody>().isKinematic = false;
        other.GetComponent<Rigidbody>().AddRelativeForce((Vector3.right * 30+Vector3.up), ForceMode.Impulse);
        other.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back*100);
        other.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right*100);

    }

    IEnumerator SomeDelay()
    {
        yield return new WaitForSeconds(6);
        gameObject.SetActive(false);
    }
}
