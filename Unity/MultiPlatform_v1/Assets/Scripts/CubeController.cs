using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed;
    public static float x_pos;
    public static float y_pos;
    public static float z_pos;
    public Rigidbody rb;

	void Start () {
        speed = 15.0f;
        rb = GetComponent<Rigidbody>();
    }
	
	void Update () {
        x_pos = this.transform.position.x;
        y_pos = this.transform.position.y;
        z_pos = this.transform.position.z;

    # if UNITY_STANDALONE_WIN
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(transform.up * speed, ForceMode.Impulse);
        }
    #endif

    #if UNITY_ANDROID
        transform.Translate(Input.acceleration.x * 0.1f, 0, 0);
    #endif
    }

}
