using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float delayBetweenLetters = 0.1f;

    private string fullText;
    private Coroutine typingCoroutine;

    private void Start()
    {
        fullText = textMeshPro.text;
        textMeshPro.text = string.Empty;

        StartTyping();
    }

    public void StartTyping()
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(TypeText());
    }

    public void StopTyping()
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        textMeshPro.text = fullText;
    }

    private IEnumerator TypeText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            textMeshPro.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(delayBetweenLetters);
        }
    }
}