using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Data object that can generate a number of dancer names
/// 
/// TODO:
///     Needs to generate the number of requested <b>unique</b> character names for the dancers in our battle
/// </summary>
[CreateAssetMenu(menuName = "Battle Objects/Character Name Generator")]
[System.Serializable]
public class CharacterNameGenerator : ScriptableObject
{
    [Header("Possible first names")]
    [SerializeField]
    public List<string> firstNames;
    [Header("Possible last names")]
    [SerializeField]
    public List<string> lastNames;
    [Header("Possible nicknames")]
    [SerializeField]
    public List<string> nicknames;
    [Header("Possible adjectives to describe the character")]
    [SerializeField]
    public List<string> descriptors;

    public CharacterName[] GenerateNames(int namesNeeded)
    {
        CharacterName[] names = new CharacterName[namesNeeded];
        
        //TODO - filling this with empty names so the rest of our code is safe to run without need for many null checks
        
        for (int i = 0; i < names.Length; i++)
        {
            // TODO for week 7 - Do this 4th
            // - Make use of the firstNames, lastNames, nicknames and
            // - descriptors lists
            CharacterName currentName = new CharacterName(firstNames[Random.Range(0, firstNames.Count)],
                                         lastNames[Random.Range(0, lastNames.Count)],
                                         nicknames[Random.Range(0, nicknames.Count)],
                                         descriptors[Random.Range(0, descriptors.Count)]);

            names[i] = currentName;
        }

        Debug.LogWarning("CharacterNameGenerator called, it needs to fill out the names array with unique randomly constructed character names");

        return names;
    }


}