using System.Collections.Generic;
using UnityEngine;

namespace FactoryCoins
{
    public abstract class Coin : MonoBehaviour
    {
        public void MoveTo(IEnumerable<Transform> points)
        {
            List<Transform> transforms = new List<Transform>(points);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICoinPicker coinPicker))
            {
                Debug.Log("Проигрывается музыка подбора монетки");
                Debug.Log("Проигрывает анимация");

                AddCoins(coinPicker);

                Destroy(gameObject);
            }
        }

        protected abstract void AddCoins(ICoinPicker coinPicker);
    }
}
