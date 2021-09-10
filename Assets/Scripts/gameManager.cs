using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject attack;
    public GameObject balloon;
    public GameObject gameoverText;
    public Text timeText;
    public Animator anim;
    
    public static gameManager I;
    private float time;
    private bool isGameOver;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("attackBalloon", 0, 0.5f);
        time = 0.0f;
        isGameOver = false;
    }

    void attackBalloon()
    {
        Instantiate(attack);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }

    public void gameOver()
    {
        isGameOver = true;
        anim.SetBool("isDie", true);
        gameoverText.SetActive(true);
        Invoke("boom", 0.5f);
    }

    void boom()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
 