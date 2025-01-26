using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    protected Rigidbody rb;

    [SerializeField] protected float worldVelocity = 25;

    [SerializeField] protected Vector3 startForce = Vector3.one;

    [SerializeField] int damage = 1;

    // Awake
    // Start
    // OnEnable


    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    protected void LimitBallVelocity()
    {
        Vector3 hv3 = rb.velocity;

        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hv3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hv3.y, -worldVelocity, worldVelocity);
        nV3.z = Mathf.Clamp(hv3.z, -worldVelocity, worldVelocity);

        rb.velocity = nV3;

    }

    private void OnCollisionEnter(Collision collision)
    {
        BreakableBrick bb = collision.gameObject.GetComponent<BreakableBrick>();
        if (bb != null)
        {
            bb.Break(damage);
        }

    }

}
