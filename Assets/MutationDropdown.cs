using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutationDropdown : MonoBehaviour
{
    //Create a List of new Dropdown options
    List<string> list = new List<string> { "option1", "option2" };
    //This is the Dropdown
    Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();
        foreach (string option in list)
        {
            dropdown.options.Add(new Dropdown.OptionData(option));
        }
    }
}