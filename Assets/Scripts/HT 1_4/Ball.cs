using System;
using UnityEngine;

public enum BallColor
{
    White,
    Red,
    Green
}
public class Ball : MonoBehaviour
{
    [SerializeField] private BallColor _ballColor;

    public static Action<Ball> OnBallDestroyed;

    public BallColor BallColor { get => _ballColor; set => _ballColor = value; }

    private void Awake()
    {
        switch (BallColor)
        {
            case BallColor.White:
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                break;
            case BallColor.Red:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case BallColor.Green:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;

        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    OnBallDestroyed?.Invoke(this);
                    Destroy(gameObject);
                }
            }
        }
    }
}
