using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Skor skor;

    private void Start()
    {
        skor = FindObjectOfType<Skor>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground" && this.tag == "Snowball")
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Ground" && this.tag != "Snowball")
        {
            Destroy(this.gameObject);
            skor.SubtractScore(2);
        }
    }
}
