using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform transRef;
    private float locX;
    private float locY;
    private float locZ;
    void Start()
    {
        transRef = this.transform;
        locX = transRef.position.x;
        locY = transRef.position.y;
        locZ = transRef.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (transRef.position.x > 20 || transRef.position.y > 100 || transRef.position.z > 20)
        {
            resetSpawn();
        }
        if (transRef.position.x < -20 || transRef.position.y < -100 || transRef.position.z < -20)
        {
            resetSpawn();
        }
    }

    public void resetSpawn()
    {
        transRef.position = new Vector3(locX, locY, locZ);
    }
}
