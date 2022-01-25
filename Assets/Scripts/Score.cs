using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform playerTransform;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
