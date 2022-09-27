using UnityEngine;
using UnityEngine.InputSystem;
public class Hero : MonoBehaviour
{

    public float movemetSpeed = 5f;
    public float jumpHeigh = 5f;
    CapsuleCollider2D capsuleCollider2D;
    Vector2 movemetVector;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 plaverVelocity = new Vector2(movemetVector.x * movemetSpeed, rbody.velocity.y);
        rbody.velocity = plaverVelocity;
    }

    private void OnMove(InputValue value)

    {
         movemetVector = value.Get<Vector2>();
        Debug.Log(movemetVector);
    }
     private void OnJump(InputValue value)
    {
        if (!capsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
    }
}
