using UnityEngine;

public class LevelUpBooster : Booster
{
    [SerializeField] private Mediator _mediator;

    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        
        Debug.Log("LevelUp");
        _mediator.Initialize(this);
    }
}
