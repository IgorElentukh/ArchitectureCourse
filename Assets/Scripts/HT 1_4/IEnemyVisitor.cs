using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public interface IEnemyVisitor
    {
        void Visit (Ork ork);
        void Visit (Human human);
        void Visit (Elf elf);
    }
}
