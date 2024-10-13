using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityControllerOnVN : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExcitementSeekingP() => PersonalityParameterOnBigFive.ExcitementSeeking += 1;
    public void ExcitementSeekingM() => PersonalityParameterOnBigFive.ExcitementSeeking -= 1;

    public void ActivityLevelP() => PersonalityParameterOnBigFive.ActivityLevel += 1;
    public void ActivityLevelM() => PersonalityParameterOnBigFive.ActivityLevel -= 1;

    public void CheerfulnessP() => PersonalityParameterOnBigFive.Cheerfulness += 1;
    public void CheerfulnessM() => PersonalityParameterOnBigFive.Cheerfulness -= 1;

    public void GregariousnessP() => PersonalityParameterOnBigFive.Gregariousness += 1; // Corrected to update Gregariousness
    public void GregariousnessM() => PersonalityParameterOnBigFive.Gregariousness -= 1;

    // Increment and decrement methods for Agreeableness components
    public void AltruismP() => PersonalityParameterOnBigFive.Altruism += 1;
    public void AltruismM() => PersonalityParameterOnBigFive.Altruism -= 1;

    public void CooperationP() => PersonalityParameterOnBigFive.Cooperation += 1; // Corrected to update Cooperation
    public void CooperationM() => PersonalityParameterOnBigFive.Cooperation -= 1;

    public void ModestyHumilityP() => PersonalityParameterOnBigFive.ModestyHumility += 1;
    public void ModestyHumilityM() => PersonalityParameterOnBigFive.ModestyHumility -= 1;

    public void MoralityP() => PersonalityParameterOnBigFive.Morality += 1;
    public void MoralityM() => PersonalityParameterOnBigFive.Morality -= 1;
}
