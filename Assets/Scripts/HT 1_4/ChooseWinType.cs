using UnityEngine;
using UnityEngine.UI;

public class ChooseWinType : MonoBehaviour
{
    [SerializeField] private CanvasRenderer _background;
    [SerializeField] private Button _allBallsBtn;
    [SerializeField] private Button _oneColorBtn;
    [SerializeField] private GameManager _gameManagerPrefab;

    public void SetAllBallWinStrategy()
    {
        GameManager _gameManager = Instantiate(_gameManagerPrefab);
        _gameManager.Strategy = 1;
        _background.gameObject.SetActive(false);
    }

    public void SetOneColorWinStrategy()
    {
        GameManager _gameManager = Instantiate(_gameManagerPrefab); 
        _gameManager.Strategy = 2;
        _background.gameObject.SetActive(false);
    }
}
