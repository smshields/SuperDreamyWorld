using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamyController : MonoBehaviour
{
    public float speed = 10f;

    public bool goalReached = true;
    public Vector3 goal;

    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        this.sr = this.GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = this.transform.position.z;
            //we have to move the goal destination to match the center of dreamy
            mousePos.x = mousePos.x - this.sr.bounds.size.x / 2;
            mousePos.y = mousePos.y + this.sr.bounds.size.y / 2;
            this.goal = mousePos;
            this.goalReached = false;
        }
        if (this.transform.position == this.goal) 
        {
            this.goalReached = true;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.goal, this.speed * Time.deltaTime);
    }


}
