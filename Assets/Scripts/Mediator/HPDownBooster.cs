using UnityEngine;

public class HPDownBooster : Booster
{
    [SerializeField] private Mediator _mediator;
    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        
        Debug.Log("HP Down");
        _mediator.Initialize(this);
    }
}
