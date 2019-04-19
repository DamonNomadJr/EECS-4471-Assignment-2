using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{

    public GameObject[] balls;
    public Text grivityText;
    public Text resetText;

    public Text welcomeText;

    public GameObject Target;
    private List<GameObject> set;
    private float startPos;
    private float distPos;

    // Start is called before the first frame update
    void Start()
    {
        this.startPos = 4f;
        this.distPos = 0.5f;
        this.set = new List<GameObject>();
        createTarget();
        StartCoroutine(this.textRemove());
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X)){
            this.toggleGravity();
        }
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            this.resetObjects();
        }

        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            createTarget();
            Debug.Log("Creating");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            destroyTarget();
            Debug.Log("Destroying");
        }
    }

    private void toggleGravity() {
        foreach(GameObject ball in this.balls)
        {
            ball.GetComponent<Rigidbody>().useGravity = !ball.GetComponent<Rigidbody>().useGravity;
            grivityText.text = ball.GetComponent<Rigidbody>().useGravity.ToString();
        }
    }

    private void resetObjects()
    {
        resetText.text = "Run";
        foreach (GameObject ball in this.balls)
        {
            ball.GetComponent<Respawn>().resetSpawn();
        }
    }

    private void createTarget()
    {
        float distance = this.distPos * this.set.Count;
        GameObject x = Instantiate(Target, new Vector3(0.4f, 0.32f, this.startPos + distance), Quaternion.identity);
        this.set.Add(x);    
    }

    private void destroyTarget()
    {
        if (this.set.Count > 0)
        {
            Destroy(this.set[this.set.Count - 1]);
            this.set.RemoveAt(this.set.Count - 1);
        }
    }

    private IEnumerator textRemove()
    {
        yield return new WaitForSeconds(6);
        Destroy(this.welcomeText);

    }

}
