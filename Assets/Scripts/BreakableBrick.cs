using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    // vars
    [SerializeField,Range(1,20)] protected int hitsToBreak;
    [SerializeField, Range(1, 20)] protected int pointValue = 3;
    protected int currHitsToBreak = 0;

    // break emitter
    [SerializeField] ParticleSystem hit_ps;

    // methods

    private void Awake()
    {
        currHitsToBreak = hitsToBreak;
    }
    public void Break(int aDamage)
    {
        currHitsToBreak -= aDamage;
        BreakBrick();
        hit_ps.Play();
    }

    protected void BreakBrick()
    {
        if (currHitsToBreak <= 0)
        {
            //FindObjectOfType<RoundManager>().RemoveBrick(this);
            GameManager.Instance.AddScore(pointValue);
            Destroy(gameObject);
        }
        
    }
    // accessors
}
