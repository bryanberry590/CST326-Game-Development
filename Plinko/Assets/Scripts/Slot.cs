using UnityEngine;
using TMPro;

public class Slot : MonoBehaviour
{

    public int slotNumber;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public int slotVal = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetScoreText();
    }

    // // Update is called once per frame
    // void Update()
    // {
    // }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} entered slot {slotNumber}");
        string currScoreText = scoreText.text;
        string[] parts = currScoreText.Split(":");
        int currScore = int.Parse(parts[1].Trim());
        score = currScore + slotVal;
        SetScoreText();
        Debug.Log("Score: " + score);
    }

    void SetScoreText(){

        scoreText.text = "Score: " + score.ToString();
    }
}
