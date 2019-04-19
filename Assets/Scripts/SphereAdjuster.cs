using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAdjuster : MonoBehaviour
{
    public GameObject weight;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float mass = gameObject.GetComponent<Rigidbody>().mass;
        this.weight.GetComponent<Text>().
    }
}
