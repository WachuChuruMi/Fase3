using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedMovement = 5.0f;
    public float speedRotate = 200.0f;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * speedRotate, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speedMovement);

        anim.SetFloat("SpdX", x);
        anim.SetFloat("SpdY", y);
    }
}
