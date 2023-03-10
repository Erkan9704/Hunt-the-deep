using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyIfColided : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public GameObject Winningsoundeffect;
    public GameObject customimage;
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    // Start is called before the first frame update
    void Start()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.yellow;
            enabled = false;
            

        }

        SetTimerText();

    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.0");
    }

    void OnCollisionEnter(Collision collsion)
    {
        if (collsion.gameObject.tag.Equals("enemy"))
        {
            customimage.SetActive(true);
            Winningsoundeffect.SetActive(true);
            Camera1.enabled = false;
            Camera2.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

            enabled = false;


        }
    }
}
