using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonalityParamater : MonoBehaviour
{
    //征服者（TJ）：素早く進行、筋重視/気にしない、社会性強い；競争・運
    //マネージャー（TP）：着実に進行、筋重視、計画性強い；競争
    //放浪者（FP）：新しいおもちゃを見つける、キャラクターの感情重視、自分がすきなことを語る；なりきり
    //参加者（FJ）：物語的な進行、キャラクターの感情重視、多人数プレイ；なりきり・運
    //ハードコア・カジュアル（N＝＝S）

    static public int TF=0;
    static public int PJ = 0;  
    static public int CH = 0;
    public Text PersonalityText;

    void Start()
    {
        // シーン遷移後も保持
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PersonalityText.text = "TF： " + TF + "\nPJ： " + PJ + "\nCH： " + CH;
      
    }
}
