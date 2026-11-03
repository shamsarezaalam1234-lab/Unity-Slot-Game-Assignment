using UnityEngine;
using System.Collections.Generic;

public class Reel : MonoBehaviour
{
    public List<Symbol> symbols = new List<Symbol>();
    public float spinSpeed = 500f;
    private bool isSpinning = false;
    private int currentIndex = 0;

    void Update()
    {
        if (isSpinning)
        {
            transform.Translate(Vector3.down * spinSpeed * Time.deltaTime);
        }
    }

    public void StartSpin()
    {
        isSpinning = true;
    }

    public void StopSpin()
    {
        isSpinning = false;
    }

    public Symbol GetCurrentSymbol()
    {
        return symbols[currentIndex];
    }
}
