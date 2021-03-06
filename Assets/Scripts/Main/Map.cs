﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour {
    public GameObject building;

    Vector3[] corners = new Vector3[4];
    GameObject[,] buildings = new GameObject[10, 10];
    Transform selector;
    Transform parent;
    void Start () {
        selector = transform.GetChild(1);
        parent = transform.parent;
        GetComponent<RectTransform>().GetWorldCorners(corners);
    }
	

	void Update () {
        if (parent.GetComponent<Updater>().EventShown)
        {
            return;
        }
        Vector2 relPos = Input.mousePosition - Camera.main.WorldToScreenPoint(corners[1]);
        Vector2Int map = new Vector2Int( (int)(relPos.x / 60), (int)(relPos.y / 60));
        Vector2 mapPos = map;
        mapPos.x *= 60;
        mapPos.x += 30;
        mapPos.y *= 60;
        mapPos.y -= 30;
        if (map.x < 0 || map.x > 9 || map.y < -9 || map.y > 0)
        {
            selector.gameObject.SetActive(false);
            return;
        } else
        {
            selector.gameObject.SetActive(true);
        }
        if (buildings[map.x, -map.y] != null)
        {
            return;
        }
        InitialCity city = parent.GetComponent<InitialCity>();
        Updater update = parent.GetComponent<Updater>();

        if (Input.GetMouseButtonUp(0))
        {
            if (!parent.GetComponent<Updater>().currentBuild.Build())
            {
                return;
            }
            buildings[map.x, -map.y] = Instantiate(building, transform.GetChild(0));
            buildings[map.x, -map.y].GetComponent<RectTransform>().anchoredPosition = mapPos;
            Color selectorColor = transform.GetChild(1).GetComponent<Image>().color;
            selectorColor.a = 1;
            buildings[map.x, -map.y].GetComponent<Image>().color = selectorColor;

            parent.GetComponent<InitialCity>().buildingList[(parent.GetComponent<Updater>().currentBuild).GetType()] += 1;

            return;
        } else
        {
            selector.GetComponent<RectTransform>().anchoredPosition = mapPos;
        }
        
    }
}
