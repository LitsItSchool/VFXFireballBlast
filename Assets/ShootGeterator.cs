using UnityEngine;
using System.Collections;

public class ShootGeterator : MonoBehaviour
{
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            var newPref = Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
