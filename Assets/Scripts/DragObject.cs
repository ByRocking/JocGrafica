using System;
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    public Rigidbody rb;
    public AudioSource soundSource;

    private void Update()
    {
        rb.velocity = new Vector3(0f, -4f, 0f);
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "whatIsGround")
            soundSource.Play();
    }
}