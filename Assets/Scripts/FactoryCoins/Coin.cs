using System.Collections.Generic;
using UnityEngine;

namespace FactoryCoins
{
    public abstract class Coin : MonoBehaviour
    {
        public void MoveTo(Vector3 point)
        {
            transform.position = point;    
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICoinPicker coinPicker))
            {
                Debug.Log("������������� ������ ������� �������");
                Debug.Log("����������� ��������");

                AddCoins(coinPicker);

                Destroy(gameObject);
            }
        }

        protected abstract void AddCoins(ICoinPicker coinPicker);
    }
}
