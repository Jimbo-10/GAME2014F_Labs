using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreLabel;

    [SerializeField]
    TMP_Text livesLabel;

    private float scoreLabelHalfHeight;
    private float scoreLabelHalfWidth;
    private float livesLabelHalfHeight;
    private float livesLabelHalfWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreLabelHalfHeight = scoreLabel.rectTransform.rect.height * 0.5f;
        scoreLabelHalfWidth = scoreLabel.rectTransform.rect.width * 0.5f;

        livesLabelHalfHeight = livesLabel.rectTransform.rect.height * 0.5f;
        livesLabelHalfWidth = livesLabel.rectTransform.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.rectTransform.position = new Vector2(
                                                    Screen.safeArea.xMin - scoreLabelHalfWidth,
                                                    Screen.safeArea.yMax - scoreLabelHalfHeight);

        livesLabel.rectTransform.position = new Vector2(
                                                    Screen.safeArea.xMax + livesLabelHalfWidth,
                                                    Screen.safeArea.yMax - livesLabelHalfHeight);
    }
}
