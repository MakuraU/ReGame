using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityParameterOnBigFive : MonoBehaviour
{
    static public float Extraversion;
    static public float ExcitementSeeking;
    static public float ActivityLevel;
    static public float Cheerfulness;
    static public float Gregariousness;
    static public float Agreeableness;
    static public float Altruism;
    static public float Cooperation;
    static public float ModestyHumility;
    static public float Morality;

    void Start()
    {
        // Keep the object from being destroyed on load
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // Calculate Extraversion and Agreeableness
        Extraversion = (ExcitementSeeking * 0.78f + ActivityLevel * 0.71f + Cheerfulness * 0.81f + Gregariousness * 0.79f);
        Agreeableness = (Altruism * 0.77f + Cooperation * 0.73f + ModestyHumility * 0.77f + Morality * 0.75f);

        // Example of n as a number of parameters; adjust if necessary
        int n = 4; // Change to match your calculation (e.g., 4 for Extraversion components)
        Debug.Log($"Extraversion: {Extraversion / n}, Agreeableness: {Agreeableness / n}");
    }

    // Increment and decrement methods for Extraversion components
    public void ExcitementSeekingPlus() => ExcitementSeeking += 1;
    public void ExcitementSeekingMinus() => ExcitementSeeking -= 1;

    public void ActivityLevelPlus() => ActivityLevel += 1;
    public void ActivityLevelMinus() => ActivityLevel -= 1;

    public void CheerfulnessPlus() => Cheerfulness += 1;
    public void CheerfulnessMinus() => Cheerfulness -= 1;

    public void GregariousnessPlus() => Gregariousness += 1; // Corrected to update Gregariousness
    public void GregariousnessMinus() => Gregariousness -= 1;

    // Increment and decrement methods for Agreeableness components
    public void AltruismPlus() => Altruism += 1;
    public void AltruismMinus() => Altruism -= 1;

    public void CooperationPlus() => Cooperation += 1; // Corrected to update Cooperation
    public void CooperationMinus() => Cooperation -= 1;

    public void ModestyHumilityPlus() => ModestyHumility += 1;
    public void ModestyHumilityMinus() => ModestyHumility -= 1;

    public void MoralityPlus() => Morality += 1;
    public void MoralityMinus() => Morality -= 1;
}
