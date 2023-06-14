using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_Raid : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog28;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog29;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog30;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog31;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog32;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog33;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog34;
    #endregion

    public SoundManager soundManager;   //SE 瓤苞澜
    public SoundManager2 soundManager2; //BGM 宏陛

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("A_P_Aspinel");    //宏陛 角青

        soundManager.PlaySound("Door_open_church"); //巩 凯府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog01.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog02.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //巩 凯府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog03.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //巩 凯府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog04.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //巩 凯府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog05.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //巩 凯府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog06.UpdateDialog());
        soundManager.PlaySound("Putdown");   //氓惑阑 啊罕霸 滴靛府绰
        yield return new WaitUntil(() => Ending_RaidDialog07.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_2").gameObject.SetActive(true);
        PadeOff();

        soundManager2.PlayBgm("A_P_Battle");    //宏陛 角青
        yield return new WaitUntil(() => Ending_RaidDialog08.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog09.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog10.UpdateDialog());
        soundManager.PlaySound("Gugugugu"); //备备备备 家府
        yield return new WaitUntil(() => Ending_RaidDialog11.UpdateDialog());
        soundManager.PlaySound("Sword_fight1"); //漠轿框 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight2"); //漠轿框 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight3"); //漠轿框 家府
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => Ending_RaidDialog12.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //戎劳 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight3"); //漠轿框 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight2"); //漠轿框 家府
        yield return new WaitUntil(() => Ending_RaidDialog13.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //谦嘛 家府
        yield return new WaitUntil(() => Ending_RaidDialog14.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //气惯 家府
        yield return new WaitUntil(() => Ending_RaidDialog15.UpdateDialog());
        soundManager.PlaySound("Magic_wind"); //官恩付过 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight1"); //漠轿框 家府
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Swoosh"); //戎劳 家府
        yield return new WaitUntil(() => Ending_RaidDialog16.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //谦嘛 家府
        yield return new WaitUntil(() => Ending_RaidDialog17.UpdateDialog());
        soundManager.PlaySound("Magic_heal"); //鳃傅 家府
        yield return new WaitUntil(() => Ending_RaidDialog18.UpdateDialog());
        soundManager.PlaySound("Sword_fight2"); //漠轿框 家府
        yield return new WaitUntil(() => Ending_RaidDialog19.UpdateDialog());
        soundManager.PlaySound("Magic_heal"); //鳃傅 家府
        yield return new WaitUntil(() => Ending_RaidDialog20.UpdateDialog());
        soundManager.PlaySound("Explosion2"); //气惯 家府
        yield return new WaitUntil(() => Ending_RaidDialog21.UpdateDialog());
        soundManager.PlaySound("Magic_wind"); //官恩付过 家府
        yield return new WaitUntil(() => Ending_RaidDialog22.UpdateDialog());
        soundManager.PlaySound("Explosion3"); //气惯 家府
        yield return new WaitUntil(() => Ending_RaidDialog23.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //戎劳 家府
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Swoosh"); //戎劳 家府
        yield return new WaitUntil(() => Ending_RaidDialog24.UpdateDialog());
        soundManager.PlaySound("Galrumgak1"); //哎烦按鞭 付过 家府

        soundManager2.PlayBgm("Raid_Hero_Die");    //宏陛 角青

        yield return new WaitUntil(() => Ending_RaidDialog25.UpdateDialog());
        soundManager.PlaySound("Galrumgak1"); //哎烦按鞭 付过 家府
        yield return new WaitUntil(() => Ending_RaidDialog26.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //林冈栏肺 锭府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog27.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //林冈栏肺 锭府绰 家府
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //林冈栏肺 锭府绰 家府
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //林冈栏肺 锭府绰 家府
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //林冈栏肺 锭府绰 家府
        yield return new WaitUntil(() => Ending_RaidDialog28.UpdateDialog());
        soundManager.PlaySound("Galrumgak2"); //哎烦按鞭 付过 家府
        yield return new WaitUntil(() => Ending_RaidDialog29.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_2").gameObject.SetActive(false);
        PadeOff();

        soundManager2.PlayBgm("Raid_End");    //宏陛 角青

        yield return new WaitUntil(() => Ending_RaidDialog30.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_3").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog31.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_5").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_4").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog32.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_6").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_5").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog33.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_7").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_6").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog34.UpdateDialog());

        GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(true);
    }

    public void PadeStart() //PadeImage 累悼
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void PadeOff() //PadeImage 累悼
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
}
