using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamyController : MonoBehaviour
{
    public float speed = 10f;

    public bool goalReached = true;
    public Vector3 goal;

    public SpriteRenderer sr;

    public float idleAnim = .8f;
    public float idleTime = 0f;

    public Sprite idle1;
    public Sprite idle2;

    // Start is called before the first frame update
    void Start()
    {
        this.sr = this.GetComponentInChildren<SpriteRenderer>();
        this.sr.sprite = idle1;
    }

    // Update is called once per frame
    void Update()
    {
        //if time has run out, swap animations, move up
        if (this.idleTime >= this.idleAnim) 
        {
            if (this.sr.sprite == idle1)
            {
                this.sr.sprite = idle2;
            }
            else 
            {
                this.sr.sprite = idle1;
            }
            this.idleTime = 0f;
        }
        this.idleTime += Time.deltaTime;



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
