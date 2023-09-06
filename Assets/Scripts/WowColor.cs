using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WowColor : MonoBehaviour
{

    public List <Color> color;
    public MeshRenderer meshRenderer;
    public float delayTime;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
        //ChangeColor();
    }

    private void OnDisable()
    {
        //ChangeColor();
    }

    private void OnMouseDown()
    {
        //ChangeColor();
    }

    private void OnMouseEnter()
    {
        //ChangeColor();
    }

    private void OnMouseExit()
    {
        //ChangeColor();
    }

    private void OnMouseOver()
    {
        //ChangeColor();
    }

    private void OnMouseDrag()
    {
        //ChangeColor();
    }

    private void OnMouseUpAsButton()
    {
        //Invoke("ChangeColor", delayTime);
        InvokeRepeating("ChangeColor", 5, 1);
        //CancelInvoke();
    }

    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
            
    }
}
