using UnityEngine;

public class Skor : MonoBehaviour
{
    private int _skor;

    public void AddScore(int amount)
    {
        _skor += amount;
        Debug.Log("Skor: " + _skor);
    }

    public void SubtractScore(int amount)
    {
        _skor -= amount;
        Debug.Log("Skor Azaldı!: " + _skor);
    }
}