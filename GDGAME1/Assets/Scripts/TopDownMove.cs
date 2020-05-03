using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{
    private Rigidbody2D rigb;
    private Vector2 PlayerMove;
    public float PlayerSpeed;
    public Camera Mouseclick;
    private Vector2 mDirection;
    private Vector2 mpos;
    private float mAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerMove.x = Input.GetAxisRaw("Horizontal");
        mpos = Mouseclick.ScreenToWorldPoint(Input.mousePosition);

    }
    private void FixedUpdate()
    {
        rigb.MovePosition(rigb.position + PlayerMove * PlayerSpeed * Time.fixedDeltaTime);
        mDirection = mpos - rigb.position;
        mAngle = Mathf.Atan2(mDirection.y, mDirection.x)*Mathf.Rad2Deg-90f;
        rigb.rotation = mAngle;

        
    }
}
