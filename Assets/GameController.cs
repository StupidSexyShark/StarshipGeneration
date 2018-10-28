using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    // Serialized fields allow access through Unity Inspector
    [SerializeField] Text textNarrative;
    [SerializeField] Text textStatsAndInv;
    [SerializeField] State startingState;

    // Creating objects
    public State state;
    public Player[] player;
    public int currentGen;
    public StateActions actions;

	// Use this for initialization
	void Start()
    {
        // currentGen is used to kee track of each generation of player character
        currentGen = 0;
        // Array of players characters. Set at 10.
        player = new Player[10];
        player[currentGen] = new Player(currentGen);
        
        // Inital state is set here.
        state = startingState;
        // actions object allows certain states to alter UI and game values
        actions = new StateActions();

        // Update UI elements for initial state.
        textNarrative.text = state.GetStateStory();
        textStatsAndInv.text = player[currentGen].GetPlayerText();
    }
	
	// Update is called once per frame
	void Update()
    {
        ManageState();	
	}

    private void ManageState()
    {
        // nextStates will contain all possible states which can be accessed
        // from the current state
        var nextStates = state.GetNextStates();
        // Key 1 will change state. This needs amending for final control mechanism
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            // initialised is a bool which controls if stats are visible on screen.
            if (!player[currentGen].initialised)
            {
                player[currentGen].initialised = true;
            }
        }

        // Update UI elements for new state.
        textNarrative.text = state.GetStateStory();
        textStatsAndInv.text = player[currentGen].GetPlayerText();
        actions.PerformActions(state);
    }

    // This method will control creation of new player characters
    private void NextGen()
    {
        currentGen++;
        player[currentGen] = new Player(currentGen);
    }

}
