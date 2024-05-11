using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public class Ork : Enemy
    {
        public override void Accept(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}
