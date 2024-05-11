using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public class EnemyKiller : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
                    {
                        enemy.Kill();
                    }
                }
            }
        }
    }
}
