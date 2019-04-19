using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringManager : MonoBehaviour
{
    private Transform transformRef;

    private Rigidbody rigitbodyRef;
    
    // Start is called before the first frame update
    void Start()
    {
        transformRef = this.gameObject.transform;
        rigitbodyRef = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transformRef.localPosition.x > 4.48f)
        {
            transformRef.localPosition = new Vector3(4.48f, 0f, 0f);
            rigitbodyRef.velocity = new Vector3(0f, 0f, 0f);
        }
        else if(transformRef.localPosition.x < 1.416228f)
        {
            transformRef.localPosition = new Vector3(1.416228f, 0f, 0f);
            rigitbodyRef.velocity = new Vector3(0f, 0f, 0f);
        }
        else
        {
            transformRef.localPosition = new Vector3(transformRef.localPosition.x, 0f, 0f);
        }
        
        /*if(controller grabs this)
        {
            transformRef.localPosition = new Vector3(controller.transform.position.x, 0f, 0f);
        }*/
    }
}
