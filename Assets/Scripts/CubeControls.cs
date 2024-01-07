using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControls : MonoBehaviour
{
    public KeyCode TranslateXIn = KeyCode.R;
    public KeyCode TranslateYIn = KeyCode.F;
    public KeyCode TranslateZIn = KeyCode.V;

    public KeyCode TranslateXDe = KeyCode.T;
    public KeyCode TranslateYDe = KeyCode.G;
    public KeyCode TranslateZDe = KeyCode.B;


    public KeyCode RotationX = KeyCode.Y;
    public KeyCode RotationY = KeyCode.H;
    public KeyCode RotationZ = KeyCode.N;


    public KeyCode ScaleXIn = KeyCode.U;
    public KeyCode ScaleYIn = KeyCode.J;
    public KeyCode ScaleZIn = KeyCode.M;
                   
    public KeyCode ScaleXDe = KeyCode.I;
    public KeyCode ScaleYDe = KeyCode.K;
    public KeyCode ScaleZDe = KeyCode.Comma;


    public KeyCode MirrorX = KeyCode.O;
    public KeyCode MirrorY = KeyCode.L;
    public KeyCode MirrorZ = KeyCode.Period;

    void Update()
    {
        MyInput();

        if (Input.GetKeyDown(MirrorX))
        {
            Vector3 scale = transform.localScale;
            scale.x = -scale.x;
            transform.localScale = scale;
        }
        if (Input.GetKeyDown(MirrorY))
        {
            Vector3 scale = transform.localScale;
            scale.y = -scale.y;
            transform.localScale = scale;
        }
        if (Input.GetKeyDown(MirrorZ))
        {
            Vector3 scale = transform.localScale;
            scale.z = -scale.z;
            transform.localScale = scale;
        }
    }

    private void MyInput()
    {
        if (Input.GetKey(TranslateXIn))
        {
            Vector3 pos = transform.position;
            pos.x += 5f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(TranslateYIn))
        {
            Vector3 pos = transform.position;
            pos.y += 5f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(TranslateZIn))
        {
            Vector3 pos = transform.position;
            pos.z += 5f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(TranslateXDe))
        {
            Vector3 pos = transform.position;
            pos.x -= 5f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(TranslateYDe))
        {
            Vector3 pos = transform.position;
            pos.y -= 5f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(TranslateZDe))
        {
            Vector3 pos = transform.position;
            pos.z -= 5f * Time.deltaTime;
            transform.position = pos;
        }


        if (Input.GetKey(RotationX))
        {
            Vector3 rotationDirection = new Vector3(200f, 0f, 0f);
            transform.Rotate(rotationDirection * Time.deltaTime);
        }
        if (Input.GetKey(RotationY))
        {
            Vector3 rotationDirection = new Vector3(0f, 200f, 0f);
            transform.Rotate(rotationDirection * Time.deltaTime);
        }
        if (Input.GetKey(RotationZ))
        {
            Vector3 rotationDirection = new Vector3(0f, 0f, 200f);
            transform.Rotate(rotationDirection * Time.deltaTime);
        }


        if (Input.GetKey(ScaleXIn))
        {
            Vector3 scale = transform.localScale;
            scale.x += Time.deltaTime;
            transform.localScale = scale;
        }
        if (Input.GetKey(ScaleYIn))
        {
            Vector3 scale = transform.localScale;
            scale.y += Time.deltaTime;
            transform.localScale = scale;
        }
        if (Input.GetKey(ScaleZIn))
        {
            Vector3 scale = transform.localScale;
            scale.z += Time.deltaTime;
            transform.localScale = scale;
        }
        if (Input.GetKey(ScaleXDe))
        {
            Vector3 scale = transform.localScale;
            scale.x -= Time.deltaTime;
            transform.localScale = scale;
        }
        if (Input.GetKey(ScaleYDe))
        {
            Vector3 scale = transform.localScale;
            scale.y -= Time.deltaTime;
            transform.localScale = scale;
        }
        if (Input.GetKey(ScaleZDe))
        {
            Vector3 scale = transform.localScale;
            scale.z -= Time.deltaTime;
            transform.localScale = scale;
        }

    }
}
