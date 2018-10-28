using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    // Player stat values
    public string primaryMutation = "None";
    public int athletics = 3;
    public int brains = 3;
    public int charm = 3;
    public int durability = 3;
    public int hp = 10;
    public int ac = 0;
    public int exp = 0;
    public bool initialised = false;
    public int bornInGeneration;

    // Set born in gen for future functionality and communications
    // between player generations
    public Player(int gen) {
        bornInGeneration = gen;}

    // Create text for UI
    public string GetPlayerText()
    {
        if (initialised)
        {
            return "Primary Mutation = " + primaryMutation + "\n\n" +
                   "Athletics = " + athletics.ToString() + "\n" +
                   "Brains = " + brains.ToString() + "\n" +
                   "Charm = " + charm.ToString() + "\n" +
                   "Durability = " + durability.ToString() + "\n\n" +
                   "HP = " + hp.ToString() + "\n" +
                   "EXP = " + exp.ToString();

        }
        else
        {
            return "Your cells are being knitted together....";
        }
    }
}
