using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blockers : MonoBehaviour {
    public bool IsThatZombie;
    public bool IsThatBlock;
    public GameObject[] Objects;
    public GameObject[] BloodSplash;
    public GameObject Bricks;
    public Text countScore;
    private bool Good = true;
    public Text countHealth;

    public Text Points;
    private void Start()
    {
        countScore = GameObject.Find("ScoreNum").GetComponent<Text>();
        countHealth = GameObject.Find("LifeNum").GetComponent<Text>();
    }
    private void Update()
    {
        if (int.Parse(countHealth.text) <= 0)
        {
            Application.LoadLevel("GameOver");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerFather" && IsThatZombie)
        {
            Destroy(gameObject);
            GameObject obj = Instantiate(Objects[Random.Range(0, Objects.Length)], transform.position, Quaternion.identity) as GameObject;
            GameObject objs = Instantiate(BloodSplash[Random.Range(0, BloodSplash.Length)], transform.position, Quaternion.identity) as GameObject;
            
            SetScore();
        }
        if (other.name == "PlayerFather" && IsThatBlock)
        {
            Destroy(gameObject);
            GameObject bricksplash = Instantiate(Bricks, transform.position, Quaternion.identity) as GameObject;
            Good = false;
            SetLife(Good);
        }
    }



    void SetLife(bool good)
    {
        if(Good)
        {
            countHealth.text = (int.Parse(countHealth.text) + 30).ToString();
        }
        else
        {
            countHealth.text = (int.Parse(countHealth.text) - 10).ToString();
        }
    }
    void SetScore()
    {
        
        countScore.text =(int.Parse(countScore.text)+10).ToString();
    }
}
