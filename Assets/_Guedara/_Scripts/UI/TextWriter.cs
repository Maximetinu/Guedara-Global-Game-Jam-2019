using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextWriter : MonoBehaviour
{

    public float letterWait = 0.1f;
    public float pointWait = 0.4f;
    public float commaWait = 0.2f;
    public float initialWait = 2.0f;
    public float finalTimeToFinish = 1.0f;

    public UnityEvent onTextFinish;

    private String text;
    private float lastUpdate;
    private int index = 0;
    private TextMeshProUGUI textMeshPro;
    private char lastChar = ' ';
    
    // Start is called before the first frame update
    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        text = textMeshPro.text;
        textMeshPro.text = "";
        lastUpdate = Time.time;
    }

    // Update is called once per frame
    private void Update()
    {
        if (text.Length <= index)
        {
            if ((lastUpdate + finalTimeToFinish) <= Time.time) onTextFinish?.Invoke();
            return;
        }

        if ((lastChar == '.' && !((lastUpdate + pointWait) <= Time.time)) ||
            (lastChar == ',' && !((lastUpdate + commaWait) <= Time.time)))
            return;

        if (index == 0 && (lastUpdate + initialWait) <= Time.time)
        {
            PrintChar(text[index]);
        } 
        else if (index > 0 && ((lastUpdate + letterWait) <= Time.time || (lastChar == '.') || (lastChar == ',')))
        {
            PrintChar(text[index]);
        }
    }

    private void PrintChar(Char charToPrint)
    {
        textMeshPro.text = textMeshPro.text + charToPrint;
        lastUpdate = Time.time;
        index++;
        lastChar = charToPrint;
    }

    public void Reset()
    {
        textMeshPro.text = text;
        lastUpdate = Time.time;
    }
}
