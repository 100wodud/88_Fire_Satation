using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    private float fadeSpeed = 0.5f;
    public bool fadeInOnStart = true;
    public bool fadeOutOnExit = true;

    public GameObject Manual;

    private CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (fadeInOnStart)
        {
            canvasGroup.alpha = 0f;
            StartCoroutine(FadeIn());
            Invoke("GotoStart", 4f);
        }

    }

    void GotoStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    IEnumerator FadeIn()
    {
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime * fadeSpeed;
            yield return null;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
