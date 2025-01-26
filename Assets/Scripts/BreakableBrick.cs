using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    // vars
    [SerializeField,Range(1,20)] protected int hitsToBreak;
    protected int currHitsToBreak = 0;
    // methods

    private void Awake()
    {
        currHitsToBreak = hitsToBreak;
    }
    public void Break(int aDamage)
    {
        currHitsToBreak -= aDamage;
        BreakBrick();
    }

    protected void BreakBrick()
    {
        if (currHitsToBreak <= 0)
        {
            //FindObjectOfType<RoundManager>().RemoveBrick(this);
            Destroy(gameObject);
        }
        
    }
    // accessors
}
