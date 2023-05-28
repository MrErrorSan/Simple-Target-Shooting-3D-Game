using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject camra;
    public GameObject bomb;
    public float speed= 15;
    float horizontalInput;
    float verticalInput;
    public float xrangeStart = -48;
    public float xrangeEnd = 48;
    public float zrangeStart = -48;
    public float zrangeEnd = 48;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput *Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        if (transform.position.x < xrangeStart)
        {
            transform.position = new Vector3(xrangeStart, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xrangeEnd)
        {
            transform.position = new Vector3(xrangeEnd, transform.position.y, transform.position.z);
        }
        if (transform.position.z < zrangeStart)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zrangeStart);
        }
        else if (transform.position.z > zrangeEnd)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zrangeEnd);
        }
        camra.transform.position = new Vector3(transform.position.x, camra.transform.position.y, transform.position.z);
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bomb, new Vector3(transform.position.x, transform.position.y - 2,transform.position.z), transform.rotation) ;
        }
    }

}
