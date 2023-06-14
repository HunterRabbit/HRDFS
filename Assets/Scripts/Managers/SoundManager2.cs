using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2 : MonoBehaviour
{
    private GameObject[] BGM;

    //브금
    public AudioClip audioruinsbgm;
    public AudioClip audiolennadie;
    public AudioClip audiointrohalfsad;
    public AudioClip audiointrohalfhappy;
    public AudioClip asinika;                       //아시니카를 위한 브금
    public AudioClip aspinel_papal_root_fight;      //아시니카 교황 루트 싸움
    public AudioClip aspinel_papal_route_order;     //아시니카 교황 루트 지시
    public AudioClip beris;                         //베리스
    public AudioClip blackmarket;                   //암시장
    public AudioClip church;                        //성당
    public AudioClip circus;                        //서커스
    public AudioClip codelia_nest;                  //코델리아의 둥지
    public AudioClip darkdramatic;                  //조아 보이 죽음 이벤트 또는 비극적 장면
    public AudioClip demon_king_road_and_demon_king;//마왕성으로 가는 길&마왕성
    public AudioClip durkan1;
    public AudioClip durkan2;
    public AudioClip durkan3;                       //두르칸 1,2,3
    public AudioClip el_Mona;                       //엘모나
    public AudioClip endes;                         //엔더스
    public AudioClip forest_enemy;                  //숲에서 싸움
    public AudioClip fourkings;                     //4대 귀족1
    public AudioClip fourkings2;                    //4대 귀족2
    public AudioClip hometown;                      //고향
    public AudioClip library_and_inn;               //도서관 & 여관
    public AudioClip library;                       //도서관
    public AudioClip mountain_climbing;             //등산
    public AudioClip nucleus_ending;                //핵엔딩
    public AudioClip pub1;                          //술집1
    public AudioClip pub2;                          //술집2
    public AudioClip setar;                         //세타르
    public AudioClip sol_church;                    //솔_성당
    public AudioClip sol_plaza;                     //솔_광장
    public AudioClip spiritking_and_treasury;       //정령왕 & 보물고
    public AudioClip superia_ending;                //수프라 엔딩
    public AudioClip supia_ending_war;              //수피아 엔딩 전투
    public AudioClip orchard;                       //인트로 과수원
    public AudioClip ugg_event;                     //어그비취 이벤트 전용
    public AudioClip a_k_battle;                    //A_K엔딩 전투 브금
    public AudioClip a_k_kachanta;                  //A_K엔딩 카찬타 등장 브금
    public AudioClip a_k_end;                       //A_K엔딩 마지막 브금
    public AudioClip a_p_order;                     //A_P엔딩 명령 브금
    public AudioClip a_p_battle;                    //A_P엔딩 전투 브금
    public AudioClip a_p_aspinel;                   //A_P엔딩 아스피넬 등장 브금
    public AudioClip a_p_end;                       //A_P엔딩 마지막 브금
    public AudioClip p_d_main;                      //P_D엔딩 메인 브금
    public AudioClip p_d_zombie;                    //P_D 좀비 브금
    public AudioClip p_d_end;                       //P_D 마지막 브금
    public AudioClip raid_hero_die;                 //Raid 용사 죽음 브금
    public AudioClip raid_end;                      //Raid 마지막 브금
    public AudioClip main_title;                    //표지 브금

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
