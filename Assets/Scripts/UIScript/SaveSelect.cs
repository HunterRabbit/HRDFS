using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.EventSystems;

public class SaveSelect : MonoBehaviour
{
    public Text[] slotText;		// 슬롯버튼 아래에 존재하는 Text들
    bool[] savefile = new bool[8];	// 세이브파일 존재유무 저장

    public Option option;

    GameObject clickObject;

    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        option = GameObject.Find("OptionCanvas").GetComponent<Option>();
        text = GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveAndLoad()
    {
        // 슬롯별로 저장된 데이터가 존재하는지 판단.
        for (int i = 0; i < 8; i++)
        {
            if (File.Exists(GameManager.instance.path + $"{i}"))	// 데이터가 있는 경우
            {
                savefile[i] = true;			// 해당 슬롯 번호의 bool배열 true로 변환
                GameManager.instance.nowSlot = i;	// 선택한 슬롯 번호 저장
                GameManager.instance.LoadData();	// 해당 슬롯 데이터 불러옴
                slotText[i].text = GameManager.instance.nowPlayer.TimeNow;	// 버튼에 시간표시
            }
            else	// 데이터가 없는 경우
            {
                slotText[i].text = "비어있음";
            }
        }
        // 불러온 데이터를 초기화시킴.(버튼에 닉네임을 표현하기위함이었기 때문)
        GameManager.instance.DataClear();
    }

    public void Slot(int number)	// 슬롯의 기능 구현
    {
        
        StartCoroutine(StartSlot(number));
    }

    public IEnumerator StartSlot(int number)
    {
        GameManager.instance.nowSlot = number;	// 슬롯의 번호를 슬롯번호로 입력함.

        if (option.SaveLoad) //세이브 상태(ture일경우)
        {
            text.text = "덮어쓰시겠습니까?";
            if (savefile[number])   // bool 배열에서 현재 슬롯번호가 true라면 = 데이터 존재한다는 뜻
            {
                
                GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject).name == "Yes" || (clickObject = EventSystem.current.currentSelectedGameObject).name == "No");
                switch (clickObject.name)
                {
                    case "Yes":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        GameManager.instance.SaveData();
                        break;
                    case "No":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        break;
                }
                
            }
            else    // bool 배열에서 현재 슬롯번호가 false라면 데이터가 없다는 뜻
            {
                GameManager.instance.SaveData();
            }
        }
        else
        {
            text.text = "불러오시겠습니까?";
            if (savefile[number])   // bool 배열에서 현재 슬롯번호가 true라면 = 데이터 존재한다는 뜻
            {
                
                GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject).name == "Yes" || (clickObject = EventSystem.current.currentSelectedGameObject).name == "No");
                switch (clickObject.name)
                {
                    case "Yes":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        GameManager.instance.LoadGame();    // 데이터를 로드하고
                        break;
                    case "No":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        break;
                }

            }
            else    // bool 배열에서 현재 슬롯번호가 false라면 데이터가 없다는 뜻
            {
                
            }
        }
        SaveAndLoad();
    }

}
