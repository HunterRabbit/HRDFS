using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2 : MonoBehaviour
{
    private GameObject[] BGM;

    //���
    public AudioClip audioruinsbgm;
    public AudioClip audiolennadie;
    public AudioClip audiointrohalfsad;
    public AudioClip audiointrohalfhappy;
    public AudioClip asinika;                       //�ƽô�ī�� ���� ���
    public AudioClip aspinel_papal_root_fight;      //�ƽô�ī ��Ȳ ��Ʈ �ο�
    public AudioClip aspinel_papal_route_order;     //�ƽô�ī ��Ȳ ��Ʈ ����
    public AudioClip beris;                         //������
    public AudioClip blackmarket;                   //�Ͻ���
    public AudioClip church;                        //����
    public AudioClip circus;                        //��Ŀ��
    public AudioClip codelia_nest;                  //�ڵ������� ����
    public AudioClip darkdramatic;                  //���� ���� ���� �̺�Ʈ �Ǵ� ����� ���
    public AudioClip demon_king_road_and_demon_king;//���ռ����� ���� ��&���ռ�
    public AudioClip durkan1;
    public AudioClip durkan2;
    public AudioClip durkan3;                       //�θ�ĭ 1,2,3
    public AudioClip el_Mona;                       //����
    public AudioClip endes;                         //������
    public AudioClip forest_enemy;                  //������ �ο�
    public AudioClip fourkings;                     //4�� ����1
    public AudioClip fourkings2;                    //4�� ����2
    public AudioClip hometown;                      //����
    public AudioClip library_and_inn;               //������ & ����
    public AudioClip library;                       //������
    public AudioClip mountain_climbing;             //���
    public AudioClip nucleus_ending;                //�ٿ���
    public AudioClip pub1;                          //����1
    public AudioClip pub2;                          //����2
    public AudioClip setar;                         //��Ÿ��
    public AudioClip sol_church;                    //��_����
    public AudioClip sol_plaza;                     //��_����
    public AudioClip spiritking_and_treasury;       //���ɿ� & ������
    public AudioClip superia_ending;                //������ ����
    public AudioClip supia_ending_war;              //���Ǿ� ���� ����
    public AudioClip orchard;                       //��Ʈ�� ������
    public AudioClip ugg_event;                     //��׺��� �̺�Ʈ ����
    public AudioClip a_k_battle;                    //A_K���� ���� ���
    public AudioClip a_k_kachanta;                  //A_K���� ī��Ÿ ���� ���
    public AudioClip a_k_end;                       //A_K���� ������ ���
    public AudioClip a_p_order;                     //A_P���� ��� ���
    public AudioClip a_p_battle;                    //A_P���� ���� ���
    public AudioClip a_p_aspinel;                   //A_P���� �ƽ��ǳ� ���� ���
    public AudioClip a_p_end;                       //A_P���� ������ ���
    public AudioClip p_d_main;                      //P_D���� ���� ���
    public AudioClip p_d_zombie;                    //P_D ���� ���
    public AudioClip p_d_end;                       //P_D ������ ���
    public AudioClip raid_hero_die;                 //Raid ��� ���� ���
    public AudioClip raid_end;                      //Raid ������ ���
    public AudioClip main_title;                    //ǥ�� ���

    AudioSource audioSource2;
    void Awake()
    {
        BGM = GameObject.FindGameObjectsWithTag("BGM");
        if (BGM.Length >= 2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        audioSource2 = GetComponent<AudioSource>();
        audioSource2.playOnAwake = false;
    }

    //Bgm
    public void PlayBgm(string action)
    {
        audioSource2.Stop();
        switch (action)
        {
            case "RuinsVillageBgm":
                audioSource2.clip = audioruinsbgm;
                break;
            case "LennaDie":
                audioSource2.clip = audiolennadie;
                break;
            case "IntroHalfSad":
                audioSource2.clip = audiointrohalfsad;
                break;
            case "IntroHalfHappy":
                audioSource2.clip = audiointrohalfhappy;
                break;
            case "Asinika":
                audioSource2.clip = asinika;
                break;
            case "Aspinel_pope_route_fight":
                audioSource2.clip = aspinel_papal_root_fight;
                break;
            case "Aspinel_pope_route_order":
                audioSource2.clip = aspinel_papal_route_order;
                break;
            case "Sol_castle_knight":
                audioSource2.clip = beris;
                break;
            case "Blackmarket":
                audioSource2.clip = blackmarket;
                break;
            case "Church":
                audioSource2.clip = church;
                break;
            case "Circus":
                audioSource2.clip = circus;
                break;
            case "Codelia_nest":
                audioSource2.clip = codelia_nest;
                break;
            case "Darkdramatic":
                audioSource2.clip = darkdramatic;
                break;
            case "Demon_King":
                audioSource2.clip = demon_king_road_and_demon_king;
                break;
            case "Durkan":
                audioSource2.clip = durkan2;
                break;
            case "El_mona":
                audioSource2.clip = el_Mona;
                break;
            case "Endes":
                audioSource2.clip = endes;
                break;
            case "Forest_Enemy":
                audioSource2.clip = forest_enemy;
                break;
            case "FourKings":
                audioSource2.clip = fourkings;
                break;
            case "FourKings2":
                audioSource2.clip = fourkings2;
                break;
            case "HomeTown":
                audioSource2.clip = hometown;
                break;
            case "Library":
                audioSource2.clip = library;
                break;
            case "Inn":
                audioSource2.clip = library_and_inn;
                break;
            case "Mountain":
                audioSource2.clip = mountain_climbing;
                break;
            case "Nuclear_Ending":
                audioSource2.clip = nucleus_ending;
                break;
            case "Pub1":
                audioSource2.clip = pub1;
                break;
            case "Pub2":
                audioSource2.clip = pub2;
                break;
            case "Setar":
                audioSource2.clip = setar;
                break;
            case "Sol_church":
                audioSource2.clip = sol_church;
                break;
            case "Sol_plaza":
                audioSource2.clip = sol_plaza;
                break;
            case "spiritKing":
                audioSource2.clip = spiritking_and_treasury;
                break;
            case "Supia_Ending":
                audioSource2.clip = superia_ending;
                break;
            case "Supia_Ending_War":
                audioSource2.clip = supia_ending_war;
                break;
            case "Orchard":
                audioSource2.clip = orchard;
                break;
            case "Ugg_Event":
                audioSource2.clip = ugg_event;
                break;
            case "A_K_Battle":
                audioSource2.clip = a_k_battle;
                break;
            case "A_K_Kachanta":
                audioSource2.clip = a_k_kachanta;
                break;
            case "A_K_End":
                audioSource2.clip = a_k_end;
                break;
            case "A_P_Order":
                audioSource2.clip = a_p_order;
                break;
            case "A_P_Battle":
                audioSource2.clip = a_p_battle;
                break;
            case "A_P_Aspinel":
                audioSource2.clip = a_p_aspinel;
                break;
            case "A_P_End":
                audioSource2.clip = a_p_end;
                break;
            case "P_D_Main":
                audioSource2.clip = p_d_main;
                break;
            case "P_D_Zombie":
                audioSource2.clip = p_d_zombie;
                break;
            case "P_D_End":
                audioSource2.clip = p_d_end;
                break;
            case "Raid_Hero_Die":
                audioSource2.clip = raid_hero_die;
                break;
            case "Raid_End":
                audioSource2.clip = raid_end;
                break;
            case "Main_Title":
                audioSource2.clip = main_title;
                break;
        }
        audioSource2.Play();
    }

    public void StopBgm()
    {
        audioSource2.Stop();
    }
}
