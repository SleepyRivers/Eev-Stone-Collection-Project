using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGotZoomies : MonoBehaviour
{

    private float speed = 12.0f;
    private Rigidbody PlayerRB;

    // Start is called before the first frame update
    void Start()
    {

        PlayerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizotal");
        float verticalInput = Input.GetAxis("Vertical");

        PlayerRB.AddForce(Vector3.forward * speed * verticalInput);
        PlayerRB.AddForce(Vector3.right * speed * horizontalInput);
    }
}
