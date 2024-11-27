using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleTimer : MonoBehaviour
{
    TMPro.TextMeshProUGUI clockText;
    // Start is called before the first frame update
    void Start()
    {
        clockText = GetComponent<TMPro.TextMeshProUGUI>();
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        clockText.text = System.DateTime.Now.ToString("HH:mm");
    }
}
