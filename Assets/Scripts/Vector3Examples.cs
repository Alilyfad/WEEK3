using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Examples : MonoBehaviour
{

    public enum Emovement
    {
        Forward,
        Backward,
        Left,
        Right
    }

    public float moveSpeed;
    public Emovement movementType;
    public Transform ptA, ptB;
    public float rangeValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovement.Forward:
        //        MoveForward();
        //        break;
        //    case Emovement.Backward:
        //        MoveBackward();
        //        break;
        //    case Emovement.Left:
        //        MoveLeft();
        //        break;
        //    case Emovement.Right:
        //        MoveRight();
        //        break;
        //    default:
        //        break;
        //}

       //transform.position = Vector3.Lerp(transform.position, ptB.position, moveSpeed *Time.deltaTime);

        float dist = Vector3.Distance(transform.position, ptB.position);
        if (dist <= rangeValue)
        {
            Debug.Log("woh");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        Gizmos.DrawWireSphere(transform.position, rangeValue);
    }

    public void MoveForward()
    {
        transform.position = Vector3.forward * moveSpeed * Time.time;
    }

    public void MoveBackward()
    {
        transform.position = Vector3.back * moveSpeed * Time.time;
    }

    public void MoveLeft()
    {
        transform.position = Vector3.left * moveSpeed * Time.time;
    }

    public void MoveRight()
    {
        transform.position = Vector3.right * moveSpeed * Time.time;
    }
}
