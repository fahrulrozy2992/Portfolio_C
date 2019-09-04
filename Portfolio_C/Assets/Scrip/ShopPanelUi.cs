using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Car_Shooter
{
    public class ShopPanelUi : MonoBehaviour
    {

        public static ShopPanelUi instance;
        [SerializeField] Button exitButton;
        [SerializeField] RectTransform itemPanel;
        List<ItemPrefebs> listItemPrefebs = new List<ItemPrefebs>();

        void Awake()
        {
            instance = this;
        }
        // Use this for initialization
        void Start()
        {
            exitButton.onClick.AddListener(ExitButtonOnClick);
            gameObject.SetActive(false);

            GameObject itemRes = Resources.Load<GameObject>("itemprefebs");

            Weapon data = Resources.Load<Weapon>("MP3");
            GameObject tempItem = Instantiate(itemRes);
            tempItem.transform.SetParent(itemPanel);
            ItemPrefebs tempData = tempItem.GetComponent<ItemPrefebs>();
            tempData.SetData("MP3", data);
            listItemPrefebs.Add(tempData);

            data = Resources.Load<Weapon>("MP4");
            tempItem = Instantiate(itemRes);
            tempItem.transform.SetParent(itemPanel);
            tempData = tempItem.GetComponent<ItemPrefebs>();
            tempData.SetData("MP4", data);
            listItemPrefebs.Add(tempData);

        }

        void ExitButtonOnClick()
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
        public void SetupShop(PlayerController pc)
        {
            for(int i = 0; i < listItemPrefebs.Count; i++)
            {
                listItemPrefebs[i].SetOnclick(pc);
            }
        }
    }
}
