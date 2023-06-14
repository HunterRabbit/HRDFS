using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private GameObject[] SE;

    //ȿ����
    public AudioClip audiopukjjik;  //��� �Ҹ�
    public AudioClip audiostone;    //�� �������� �Ҹ�, �ޱ׶�
    public AudioClip absurd;    //Ȳ�����ϴ� �Ҹ�
    public AudioClip bone_break_fold;   //���� �μ����� ������ �Ҹ�
    public AudioClip bone_fold; //���� ������ �Ҹ�
    public AudioClip charge;    //���� �� �Լ��Ҹ�
    public AudioClip codelia_howling;   //�ڵ����� �����Ҹ�
    public AudioClip door_open_churc;   //���� ������ ������ �Ҹ�
    public AudioClip explosion1;    //���� 1
    public AudioClip explosion2;    //���� 2
    public AudioClip explosion3;    //���� 3
    public AudioClip explosion4;    //���� 4
    public AudioClip Galrumgak1;    //�ƽ��ǳ� ��Ȳ ��Ʈ �� ������ ���� �Ҹ�
    public AudioClip Galrumgak2;    //�ƽ��ǳ� ��Ȳ ��Ʈ �� ������ ���� �Ҹ�
    public AudioClip glass_break;   //���� ������ �Ҹ� �Ǵ� Į �μ����� �Ҹ�
    public AudioClip gugugugu;      //���� �����ϴ� �Ҹ�
    public AudioClip heavy_punch;   //���ſ� ��ġ
    public AudioClip knock_off;     //�н� �������� �Ҹ�
    public AudioClip magic_heal;    //ġ�� ���� ����ϴ� �Ҹ�
    public AudioClip magic_sharara; //���� ����� �ϴ� �Ҹ�, ����� �аų� �׷���
    public AudioClip magic_wind;    //�ٶ� ���� ����ϴ� �Ҹ�, �Ҷ���
    public AudioClip monster1;      //���� 1
    public AudioClip monster2;      //���� 2
    public AudioClip monster3;      //���� 3
    public AudioClip mood_dark;     //��ο� ������
    public AudioClip move_fast;     //��� �̵�, ���
    public AudioClip nuclear_bomb;  //����ź ����
    public AudioClip run_aspart;    //�ƽ���Ʈ ���� ��������
    public AudioClip shock;         //��ݹ޴� �Ҹ�
    public AudioClip sword_fight1;  //Į ���� �ε����� �Ҹ� 1
    public AudioClip sword_fight2;  //Į ���� �ε����� �Ҹ� 2
    public AudioClip sword_fight3;  //Į ���� �ε����� �Ҹ� 3
    public AudioClip sword_slash;   //Į�� ���� �Ҹ�
    public AudioClip warp;          //�����̵��ϴ� �Ҹ�
    public AudioClip swoosh; //���ϴ� �Ҹ�
    public AudioClip body_punch; //������ �Ҹ�
    public AudioClip animal_growl; //������ �Ҹ�
    public AudioClip metal_crash; //���׶�, ©�� �ϴ� �Ҹ�
    public AudioClip knuckle_crack; //�� �ǵ�� �ϴ� �Ҹ�
    public AudioClip walking1; //������� �͹��͹� �ȴ� �Ҹ�
    public AudioClip walking2; //��ũ��Ʈ �ٴ� �ȴ� �Ҹ�
    public AudioClip cry1; //����� �Լ��Ҹ�
    public AudioClip electricity; //���� ������ �Ҹ�
    public AudioClip nuclear_button;    //�ٿ��� ��ư ������ �Ҹ�
    public AudioClip putdown;   //���� �������� �Ҹ�
    public AudioClip nuclear_alram; //�� �溸
    public AudioClip big_city; //�뵵�� ȿ����
    public AudioClip close_door; //�� �ݴ� �Ҹ�

    AudioSource audioSource;

    void Awake()
    {
        SE = GameObject.FindGameObjectsWithTag("SE");
        if(SE.Length>=2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    //ȿ����
    public void PlaySound(string action)
    {
        audioSource.Stop();
        switch (action)
        {
            case "Pukjjik":
                audioSource.clip = audiopukjjik;
                break;
            case "Stone":
                audioSource.clip = audiostone;
                break;
            case "Absurd":
                audioSource.clip = absurd;
                break;
            case "Bone_break_fold":
                audioSource.clip = bone_break_fold;
                break;
            case "Bone_fold":
                audioSource.clip = bone_fold;
                break;
            case "Charge":
                audioSource.clip = charge;
                break;
            case "Codelia_howling":
                audioSource.clip = codelia_howling;
                break;
            case "Door_open_church":
                audioSource.clip = door_open_churc;
                break;
            case "Explosion1":
                audioSource.clip = explosion1;
                break;
            case "Explosion2":
                audioSource.clip = explosion2;
                break;
            case "Explosion3":
                audioSource.clip = explosion3;
                break;
            case "Explosion4":
                audioSource.clip = explosion4;
                break;
            case "Galrumgak1":
                audioSource.clip = Galrumgak1;
                break;
            case "Galrumgak2":
                audioSource.clip = Galrumgak2;
                break;
            case "Glass_break":
                audioSource.clip = glass_break;
                break;
            case "Gugugugu":
                audioSource.clip = gugugugu;
                break;
            case "Heavy_punch":
                audioSource.clip = heavy_punch;
                break;
            case "Knock_off":
                audioSource.clip = knock_off;
                break;
            case "Magic_heal":
                audioSource.clip = magic_heal;
                break;
            case "Magic_sharara":
                audioSource.clip = magic_sharara;
                break;
            case "Magic_wind":
                audioSource.clip = magic_wind;
                break;
            case "Monster1":
                audioSource.clip = monster1;
                break;
            case "Monster2":
                audioSource.clip = monster2;
                break;
            case "Monster3":
                audioSource.clip = monster3;
                break;
            case "Mood_dark":
                audioSource.clip = mood_dark;
                break;
            case "Move_fast":
                audioSource.clip = move_fast;
                break;
            case "Nuclear_bomb":
                audioSource.clip = nuclear_bomb;
                break;
            case "Run_aspart":
                audioSource.clip = run_aspart;
                break;
            case "Shock":
                audioSource.clip = shock;
                break;
            case "Sword_fight1":
                audioSource.clip = sword_fight1;
                break;
            case "Sword_fight2":
                audioSource.clip = sword_fight2;
                break;
            case "Sword_fight3":
                audioSource.clip = sword_fight3;
                break;
            case "Sword_slash":
                audioSource.clip = sword_slash;
                break;
            case "Warp":
                audioSource.clip = warp;
                break;
            case "Swoosh":
                audioSource.clip = swoosh;
                break;
            case "Body_punch":
                audioSource.clip = body_punch;
                break;
            case "Animal_growl":
                audioSource.clip = animal_growl;
                break;
            case "Metal_crash":
                audioSource.clip = metal_crash;
                break;
            case "Knuckle_crack":
                audioSource.clip = knuckle_crack;
                break;
            case "Walking1":
                audioSource.clip = walking1;
                break;
            case "Walking2":
                audioSource.clip = walking2;
                break;
            case "Cry1":
                audioSource.clip = cry1;
                break;
            case "Electricity":
                audioSource.clip = electricity;
                break;
            case "Nucelar_Button":
                audioSource.clip = nuclear_button;
                break;
            case "Putdown":
                audioSource.clip = putdown;
                break;
            case "Nuclear_Alarm":
                audioSource.clip = nuclear_alram;
                break;
            case "Big_City":
                audioSource.clip = big_city;
                break;
            case "Close_Door":
                audioSource.clip = close_door;
                break;
        }
        audioSource.PlayOneShot(audioSource.clip);
    }

}
