using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour {

    GameObject eventScreen;
    GameObject map;
    public Building currentBuild;
    Dictionary<string, Option[]> events;
    Dictionary<string, bool> UnlockedBuildings;

	public bool EventShown
    {
        get
        {
            return false;
        }
    }

	void Start () {
        events = new Dictionary<string, Option[]>();

        eventScreen = transform.Find("Event").gameObject;
        map = transform.Find("Map").gameObject;
        eventScreen.SetActive(false);
        StartCoroutine(IncomeCycle());
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SelectBuilding(Building build)
    {
        Transform selector = map.transform.GetChild(1);
        Color selectorColor = build.Color;
        selectorColor.a = .5f;
        selector.GetComponent<Image>().color = selectorColor;
        currentBuild = build;
    }

    IEnumerator TestingEvent()
    {
        yield return new WaitForSeconds(1);

        Option o1 = new Option("testing 1", "Money");
        Option o2 = new Option("testing 2", "Money");
        Option o3 = new Option("testing 3", "Money");
        Option o4 = new Option("testing 4", "Money");
        eventScreen.GetComponent<Event>().NewEvent("we are now testing", new Option[4] { o1, o2, o3, o4});
        eventScreen.SetActive(true);
    }
    IEnumerator IncomeCycle()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(10);
            
            GetComponent<InitialCity>().Money += 1000;
            GetComponent<InitialCity>().UpdateStats();
            if (GetComponent<InitialCity>().WinElection())
            {

            }
        }
    }
}
