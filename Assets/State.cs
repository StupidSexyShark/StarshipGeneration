using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "state")]
public class State : ScriptableObject {

    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] string stateName;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

    public string GetStateName()
    {
        return stateName;
    }

}
