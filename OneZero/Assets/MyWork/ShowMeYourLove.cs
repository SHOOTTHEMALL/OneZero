using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShowMeYourLove : MonoBehaviour
{
    private int hisHeart = 0;

    protected abstract void getLove();
    protected abstract void loseLove();
}
