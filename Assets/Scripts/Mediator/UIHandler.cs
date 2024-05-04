using System;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public event Action OnLevelRestart;
    
    [SerializeField] private Text _levelNrText;
    [SerializeField] private Text _HPAmountText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private int _damage = 10;
    [SerializeField] private int _maxHealth = 100;

    private int _levelNr;
    private int _hpAmount;

    private void Awake()
    {
        _restartButton.onClick.AddListener(RestartLevel);
        _restartButton.gameObject.SetActive(false);
    }
    private void Start()
    {
        RestartLevel();
    }

    private void UpdateUIValues()
    {
        _levelNrText.text = _levelNr.ToString();
        _HPAmountText.text = _hpAmount.ToString();
    }

    public void AddLevel()
    {
        _levelNr++;
        Debug.Log(_levelNr);
        UpdateUIValues();
    }

    public void TakeDamage()
    {
        _hpAmount -= _damage;
        UpdateUIValues();

        if (_hpAmount <= 0)
        {
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void RestartLevel()
    {
        _levelNr = 1;
        _hpAmount = _maxHealth;

        UpdateUIValues();

        Time.timeScale = 1;
        _restartButton.gameObject.SetActive(false);

        OnLevelRestart?.Invoke();
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveAllListeners();
    }


}
