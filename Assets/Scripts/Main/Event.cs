using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour {

    Option[] options = new Option[4];
	
    public void NewEvent(string name, Option[] options)
    {
        gameObject.SetActive(true);
        transform.GetChild(0).GetChild(0).GetComponent<Text>().text = name;
        Transform optionText = transform.GetChild(1);
        for(int i = 0; i < options.Length; i++)
        {
            string itemName = options[i].Name;
            optionText.GetChild(i).GetChild(0).GetComponent<Text>().text = itemName;
            optionText.GetChild(i).GetComponent<Button>().onClick.AddListener(() => gameObject.SetActive(false));
        }
    }
}
