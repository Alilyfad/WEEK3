using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEEK3 : MonoBehaviour
{

    public Quaternion currentRotation;

    public Vector3 currentEularAngles;
    float x, y, z;
    public float rotSpeed;
    public Transform Target_A, Target_B;
    public float timeCount = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.Euler (90, 90, 90);
        //transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        // RotationInputs();

        //QuaternionRotateTowards();

        //QuaternionSlerp();

        LookRotation();
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 20;
        //Use the Euler angles to show the euler angles of the transform rotation

        GUI.Label(new Rect(10, 0, 0, 0), 
            "Rotating on X" + x + "Y" + y + "Z" + z, style);
        //Outputs the Quaternion.euler angle values
        GUI.Label(new Rect(10, 25, 0, 0), 
            "Current Euler Angles" + currentEularAngles, style);
        //Outputs the transform.eulerAngles of the GameObject
        GUI.Label(new Rect(10, 50, 0, 0), 
            "Game Object World Euler Angles" + transform.eulerAngles, style);


    }

    void RotationInputs()
    {
        if (Input.GetKeyDown(KeyCode.X)) { x = 1 - x; }
        if (Input.GetKeyDown(KeyCode.Y)) { y = 1 - y; }
        if (Input.GetKeyDown(KeyCode.Z)) { z = 1 - z; }

        //Modify the vector 3 based on input multiplied by time and rotspeed
        currentEularAngles += new Vector3(x, y, z)  * Time.deltaTime * rotSpeed;
        //Moving the value of vector 3 into Quaternion.Angle
        currentRotation.eulerAngles = currentEularAngles;
        //Rotatess the Game Object based on the Quaternion.Angle
        transform.rotation = currentRotation;

    }

    void QuaternionRotateTowards()
    {
        var step = rotSpeed * Time.time;
        transform.rotation = 
            Quaternion.RotateTowards(transform.rotation, Target_A.rotation, step);
    }

    void QuaternionSlerp()
    {
        transform.rotation = Quaternion.Slerp(Target_A.rotation, Target_B.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
    }

    void LookRotation()
    {
        Vector3 relativePos = Target_A.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;

    }
}
