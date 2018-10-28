using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateActions : MonoBehaviour {

    public Dropdown mutations;

	// Use this for initialization
	void Start () {
        mutations.Hide();
        mutations.onValueChanged.AddListener(delegate { mutationsValueChangedHandler(mutations); });
        mutations.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PerformActions(State currentState) 
    {
        if(currentState.GetStateName() == "Wake")
        {
            mutations.Show();
            mutations.interactable = true;
        }
    }

    private void mutationsValueChangedHandler(Dropdown target)
    {
        Debug.Log("selected: " + target.value);
    }
}
