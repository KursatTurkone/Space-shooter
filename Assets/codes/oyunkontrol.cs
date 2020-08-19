using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public GameObject astreoid;
    public Vector3 randomPos;
    public float baslangicbekleme;
    public float olusturmabekleme;
    public float dongubekleme;
    public Text text;
    bool yenidenbaslaknt = false;
    int score;
    bool oyunbittiKnt = false;
    public Text oyunbittitext;
    public Text yenidenbaslatext;
    void Start()
    {
        score = 0;
        text.text = "score=" + score;
      
        StartCoroutine(olustur());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&& yenidenbaslaknt) {
            SceneManager.LoadScene("bölüm1");
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(baslangicbekleme);
        while(true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmabekleme);

            }
            
            if (oyunbittiKnt)
            {
                yenidenbaslatext.text = "yeniden başlamak için R tuşuna basınız";
                yenidenbaslaknt = true;
                break;
            }
            yield return new WaitForSeconds(dongubekleme);
        }



    }
    public void ScoreArttir(int gelenscore)
    {
        score  += gelenscore;
        text.text = "score=" + score;
        Debug.Log(score);
    }
    public void Oyunbitti()
    {
        oyunbittitext.text = "OYUN BİTTİ";
        oyunbittiKnt = true;
    }
    
}
