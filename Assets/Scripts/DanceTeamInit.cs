﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// This class generates and assigns names to the 2 dance teams in our dance off battle.
/// It also controls the number of dancers on each team via the inspector
/// It also uses the name generator to pass character names to the teams so they can initialise
/// 
/// TODO:
///     Generate unique team names for both teams and assign them via team_.SetTroupeName(str);
///     Use the nameGenerator to get enough names for the number of dancers on both teams and pass the required names via array to each team for init (InitaliseTeamFromNames)
/// </summary>
public class DanceTeamInit : MonoBehaviour
{
    public DanceTeam teamA, teamB;

    public GameObject dancerPrefab;
    public int dancersPerSide = 3;
    public CharacterNameGenerator nameGenerator;

    private void OnEnable()
    {
        GameEvents.OnBattleInitialise += InitTeams;
    }
    private void OnDisable()
    {
        GameEvents.OnBattleInitialise -= InitTeams;
    }

    void InitTeams()
    {
        Debug.LogWarning("InitTeams called, needs to generate names for the teams and set them with teamA.SetTroupeName");
        //TODO this third
        //set the troupe names for teamA and teamB
        teamA.SetTroupeName("RED");
        teamB.SetTroupeName("BLUE");

        var namesForA = nameGenerator.GenerateNames(dancersPerSide);
        var namesForB = nameGenerator.GenerateNames(dancersPerSide);

        //get list of names from name generator
        //use the variable namegenerator to generate names
        //namegenerator has a GenerateName function

        //initialise the team names for team A and B
        //Example:
        //namesForA and namesForB should be based what you get from generator.
        teamA.InitaliseTeamFromNames(dancerPrefab, 1, namesForA);
        teamB.InitaliseTeamFromNames(dancerPrefab, -1, namesForB);
        Debug.LogWarning("InitTeams called, needs to create character names via CharacterNameGenerator and get them into the team.InitaliseTeamFromNames");
    }
}
